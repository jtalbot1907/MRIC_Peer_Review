using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRIC_Peer_Review.Processes
{
    class UpdatingProfile : DatabaseQuery
    {

        private string specialism;
        private string firstname;
        private int surname;
        public UpdatingProfile(int reviewId, string comments, int rate)
        {
        //    this. = reviewId;
        //    this.comments = comments;
        //    this.rate = rate;
        }

        public void SaveComment()
        {
        //    string sqlQuery = "INSERT INTO comments (reviewId, comments, rate) " +
        //        "VALUES (" + reviewId + ", '" + comments + "'," + rate + ");";
        //    Create(sqlQuery);
        //    sqlQuery = "Update Reviews SET status = 'open' where reviewId = " + reviewId + ";";
        //    Console.WriteLine(sqlQuery);
        //    Update(sqlQuery);
        }
    }
}
