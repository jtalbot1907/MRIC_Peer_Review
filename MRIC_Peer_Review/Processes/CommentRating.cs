using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRIC_Peer_Review.Processes
{
    class CommentRating : DatabaseQuery
    {
        int commentId;

        public CommentRating (int commentId)
        {
            this.commentId = commentId;
        }

        public DataTable GetReviewsAllStatus()
        {
            string sqlQuery = "select rv.reviewId,rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.rdocId = rd.rdocId and rv.reviewerId = " + commentId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsAwaiting()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.status ='Awaiting' and rv.rdocId = rd.rdocId and rv.reviewerId = " + commentId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsOpen()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.status ='Open' and rv.rdocId = rd.rdocId and rv.reviewerId = " + commentId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsLocked()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.status ='Locked' and rv.rdocId = rd.rdocId and rv.reviewerId = " + commentId + "; ";
            return Read(sqlQuery);
        }

        public DataTable GetReviewsClosed()
        {
            string sqlQuery = "select rv.reviewId, rd.title,rd.link,rv.specialism,rv.status from reviews rv inner join rdocs rd " +
                "where rv.status ='Closed' and rv.rdocId = rd.rdocId and rv.reviewerId = " + commentId + "; ";
            return Read(sqlQuery);
        }

    }
}
