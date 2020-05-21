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
            string sqlQuery = "Update Comments Set rate = " + rate + " where commentId = " + commentId + " ;";
            Update(sqlQuery);
            UpdateStatus();
        }
        private void UpdateStatus()
        {
            int countCommentsForAReview;
            int countRatedComments;
            string sqlQuery = "SELECT reviewId from comments where commentId = " + commentId + ";";
            string newStatus = status;
            reviewId = GetInteger(sqlQuery);
            sqlQuery = "SELECT status from reviews where reviewId = " + reviewId + ";";
            status = GetString(sqlQuery);
            sqlQuery = "SELECT count(commentId) from comments where reviewId = " + reviewId + ";";
            countCommentsForAReview = GetInteger(sqlQuery);
            sqlQuery = "SELECT count(commentId) from comments where reviewId = " + reviewId + " AND rate IS NOT NULL;";
            countRatedComments = GetInteger(sqlQuery);

            switch (status)
            {
                case "open":

                    if (countCommentsForAReview == 1)
                    {
                        //change status from open to closed
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
                        //change status from locked to closed
                        newStatus = "closed";
                    }
                    break;
            }
            sqlQuery = "Update Reviews Set status = '" + newStatus + "' where reviewId = " + reviewId + " ;";
            Update(sqlQuery);
        }
    }
}
