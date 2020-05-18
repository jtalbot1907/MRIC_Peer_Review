using System.Data;

namespace MRIC_Peer_Review.Processes
{
    class ExtractComments : DatabaseQuery
    {
        private int authorId;


        public ExtractComments()
        {
            this.authorId = LoginForm.authorId;
        }

        public DataTable GetAllOpenAndLockedComments()
        {
            string sqlQuery = "select  ct.commentId,rd.title, rv.status, ct.comments, ct.rate from rdocs rd " +
                                "inner join reviews rv on rd.rdocId = rv.rdocId " +
                                "inner join comments ct on rv.reviewId = ct.reviewId " +
                                "where(rv.status = 'open' OR rv.status = 'locked') AND rd.authorId = " + authorId + ";";
            return Read(sqlQuery);
        }
    }
}
