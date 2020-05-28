using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MRIC_Peer_Review.Processes
{
    class ExtractReviews : DatabaseQuery
    {
         int reviewerId;


        public ExtractReviews(int reviewerId)
        {
            this.reviewerId = reviewerId;
        }

        public DataTable GetReviewsAllStatus()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsAwaiting()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.status ='Awaiting' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }
        
        public DataTable GetReviewsOpen()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.status ='Open' and rv.rdocId = rd.rdocId and rv.reviewerId =" + reviewerId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsLocked()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.status ='Locked' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsClosed()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.status ='Closed' and rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetAllRdocs()
        {
            string sqlQuery = "select rv.reviewId, rd.Title, rv.Specialism, rv.Status, rd.link from reviews rv inner join rdocs rd " +
                "where rv.rdocId = rd.rdocId and rv.reviewerId = " + reviewerId + "; ";
            return Read(sqlQuery);
        }
    }
}
