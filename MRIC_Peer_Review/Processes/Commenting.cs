using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRIC_Peer_Review.Processes
{

    class Commenting : DatabaseQuery
    {

        private int reviewId;
        private string comments;
        public Commenting(int reviewId, string comments)
        {
            this.reviewId = reviewId;
            this.comments = comments;
        }

        public void SaveComment()
        {
            string sqlQuery = "INSERT INTO comments (reviewId, comments) " +
                "VALUES (" + reviewId + ", '" + comments + "');";
            Create(sqlQuery);
            sqlQuery = "Update Reviews SET status = 'open' where reviewId = " + reviewId + ";";
            Console.WriteLine(sqlQuery);
            Update(sqlQuery);
        }
    }
}
