using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
   public abstract class Personal
    {
        public string ID="";
        public string fullName="";
        public string Notes="";
        public string workUnit="";
        public List<Client> clients = new List<Client>();
        public int clientCounter = 0;
        public List<Client> logbook = new List<Client>();
        public Personal()
        {
            //to do..
        }
        public abstract void addCall(string ID,string Name);
        public abstract void endCall(string ID, string Name);
        public abstract void newCall();
        public abstract string showCallHistory();
        public abstract string showPending();
        public abstract void addNote(string ID,string Note);
        public abstract string showNote(string ID);
        public abstract string listNotes(string type);
        public abstract Node specialCall(int position);
        public abstract void endSpecialCall();
    }
}
