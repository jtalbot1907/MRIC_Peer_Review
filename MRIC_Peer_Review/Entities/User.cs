
namespace MRIC_Peer_Review
{
    class User: DatabaseQuery
    {
        
        public string Firstname {get; set;}
        public string Surname {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public string [] SpecialismList {get; set;}
    }
}
