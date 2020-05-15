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
        private int rate;
        public Commenting(int reviewId, string comments, int rate)
        {
            this.reviewId = reviewId;
            this.comments = comments;
            this.rate = rate;
        }

        public void SaveComment()
        {
            string sqlQuery = "INSERT INTO comments (reviewId, comments, rate) " +
                "VALUES (" + reviewId + ", '" + comments + "'," + rate + ");";
            Create(sqlQuery);
            sqlQuery = "Update Reviews SET status = 'open' where reviewId = " + reviewId + ";";
            Console.WriteLine(sqlQuery);
            Update(sqlQuery);
        }
    }
}
