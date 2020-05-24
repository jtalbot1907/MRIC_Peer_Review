using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MRIC_Peer_Review.Processes
{
    class RateRecorder : DatabaseQuery
    {
        private int reviewId, commentId, rate;
        private string status;
        public RateRecorder(int commentId, int rate)
        {
            this.commentId = commentId;
            this.rate = rate;
        }

        public void RecordRate()
        {
            string sqlQuery = "Update Comments Set rate = "+rate+" where commentId = "+commentId+" ;";
            Update(sqlQuery);
            UpdateStatus();
        }

        private string getSpecialism(int reviewId)
        {
            string specialism;
            string sqlQuery = "select specialism from reviews where reviewId= "+reviewId+";";
            specialism = GetString(sqlQuery);
            return specialism;
        }

        private int getReviewerId(int reviewId)
        {
            int reviewerId;
            string sqlQuery = "select reviewerId from reviews where reviewId= "+reviewId+";";
            reviewerId = GetInteger(sqlQuery);
            return reviewerId;
        }

        private double calculateReviewAverage(int reviewId)
        {
            double average;
            string sqlQuery;
            sqlQuery = "select avg(ct.rate) from reviews rv inner join comments ct " +
                            "ON rv.reviewId = "+reviewId+" where rv.reviewId = ct.reviewId";
            average = GetDouble(sqlQuery);
            return average;
        }

        private void updateReviewAverage(int reviewId)
        {
            string sqlQuery;
            double average;
            average = calculateReviewAverage(reviewId);
            sqlQuery = "Update reviews Set reviewAverage ="+average+" where reviewId= "+reviewId+";";
            Update(sqlQuery);
        }

        private void updateReviewerSpecialismsAverage(int reviewId)
        {
            double averageFromReviewerSpecialismsTable;
            double averageFromReviewsTable;
            double updatedAverage;
            string specialism;
            int reviewerId;
            string sqlQuery = "select rs.average from reviewerspecialisms rs inner join reviews rv on rv.reviewId = "+reviewId+" " +
                "where rv.reviewerId = rs.reviewerId AND rv.specialism = rs.specialism;";
            averageFromReviewerSpecialismsTable = GetDouble(sqlQuery);
            averageFromReviewsTable = calculateReviewAverage(reviewId);
            updatedAverage = (averageFromReviewerSpecialismsTable + averageFromReviewsTable) / 2;
            specialism = getSpecialism(reviewId);
            Console.WriteLine(specialism);
            reviewerId = getReviewerId(reviewId);
            Console.WriteLine(reviewerId);
            sqlQuery = "update reviewerspecialisms set average= "+updatedAverage+" where reviewerId= "+reviewerId+" " +
                "and specialism= '"+specialism+"';";
            Update(sqlQuery);
        }

        private void UpdateStatus()
        {
            int countCommentsForAReview;
            int countRatedComments;
            string sqlQuery = "SELECT reviewId from comments where commentId = " + commentId + ";";
            reviewId = GetInteger(sqlQuery);
            sqlQuery = "SELECT status from reviews where reviewId = " + reviewId + ";";
            status = GetString(sqlQuery);
            string newStatus = status;
            sqlQuery = "SELECT count(commentId) from comments where reviewId = " + reviewId + ";";
            countCommentsForAReview = GetInteger(sqlQuery);
            sqlQuery = "SELECT count(commentId) from comments where reviewId = " + reviewId + " AND rate IS NOT NULL;";
            countRatedComments = GetInteger(sqlQuery);
            switch (status)
            {
                case "open":

                    if (countCommentsForAReview == 1)
                    {
                        //change status from open to closed and Update ReviewAverage
                        updateReviewAverage(reviewId);
                        updateReviewerSpecialismsAverage(reviewId);
                        newStatus = "closed";
                    }
                    else
                    {
                        //change status from open to locked
                        newStatus = "locked";
                    }
                    break;

                case "locked":
                    if (countRatedComments == countCommentsForAReview)
                    {
                        //change status from locked to closed and update ReviewAverage
                        updateReviewAverage(reviewId);
                        updateReviewerSpecialismsAverage(reviewId);
                        newStatus = "closed";
                    }
                    break;
            }
            sqlQuery = "Update Reviews Set status = '" + newStatus + "' where reviewId = " + reviewId + " ;";
            Update(sqlQuery);
        }
    }
}
