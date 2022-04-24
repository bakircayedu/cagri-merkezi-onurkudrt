using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
   public class Client
    {
        public string fullName;
        public string clientType;
        public string ID;
        public string Note;
        public Client(string ID,string fullName,string cType)
        {
            this.ID = ID;
            this.fullName = fullName;
            this.clientType = cType;
            Note = "";
        }
    }
}
