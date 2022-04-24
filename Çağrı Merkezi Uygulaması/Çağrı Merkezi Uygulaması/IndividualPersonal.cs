using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
    public class IndividualPersonal:Personal
    {
       public Call call = new Call("Bireysel Arama");
        public IndividualPersonal(string fullName,string ID)
        {
            this.ID = ID;
            workUnit = "Bireysel Müşteri Temsilcisi";
            this.fullName = fullName;
            call.callIdentifier = "Bireysel Görüşme";
        }
        //Sıraya arama al
        public override void addCall(string ID, string Name)
        {
            call.addCall(ID, Name, "Bireysel Müşteri");
            Search search = new Search(clients);
            bool isAvaible = search.isAvaible(ID);
            if ( !(isAvaible) )
            {
                Client c = new Client(ID,Name,"Bireysel Müşteri");
                clients.Add(c);
                clientCounter++;
            }
        }
        //Yeni çağrı al
        public override void newCall()
        {
            call.startCall();
        }
        //Çağrıyı bitir
        public override void endCall(string ID, string Name)
        {
            call.endCall(ID, Name, "Bireysel Müşteri");
        }
        //Arama geçmişini görüntüle
        public override string showCallHistory()
        {
           // string representative ="Temsilci ID: "+ID.ToString()+"\nTemsilci Adı: "+fullName+"\nAlan: "+workUnit;
            string list = call.history.allList();
            return list+"\n\n";
        }
        //Sırada bekleyenleri görüntüle
        public override string showPending()
        {
            string representative="Temsilci ID: "+ID.ToString()+"\nTemsilci Adı: "+fullName+"\nAlan: "+workUnit;
            string list = call.active.allList();
            return representative+"\nSIRADA BEKLEYENLER\n\n"+list;
        }
        //Not ekle
        public override void addNote(string ID,string Note)
        {
            Search search = new Search(clients);
            Client c = search.linearSearch(ID);
            c.Note = Note;
        }
        //Müşteri notunu görüntüle
        public override string showNote(string ID)
        {
            Search search = new Search(clients);
            Client client =search.linearSearch(ID);
            if (client.fullName == "")
                return "Girilen ID için not bulunamadı.";
            return "ID: "+client.ID+"\nAdı: "+client.fullName+"\nNot:\n"+client.Note;
        }
        //Notları listele
        public override string listNotes(string type)
        {
            string temp = "";
            Sorting sorting = new Sorting(type,clients);
            List<Client> c = sorting.sort();
            for (int i = 0; i < c.Count; i++)
                temp +="\nID: "+c[i].ID+"\nAdı:"+c[i].fullName+"\nTip: "
                    +c[i].clientType+"\nNot:\n"+c[i].Note+"\n\n\n";

            return "Temsilci " + fullName + " tarafından müşteriler için alınan notlar\n" + temp;
        }

        //Özel çağrı al
        public override Node specialCall(int position)
        {
            call.specialCall(position);
            return call.special;
        }
        //Özel çağrıyı bitir
        public override void endSpecialCall()
        {
            throw new NotImplementedException();
        }
    }
}
