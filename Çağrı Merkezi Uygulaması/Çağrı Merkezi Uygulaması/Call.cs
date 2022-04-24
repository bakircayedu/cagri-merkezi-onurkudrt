using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
   public class Call
    {
        int callCount = 0;
        public string callIdentifier;
        public bool callState=false;
        public string startDate;
        public string endDate;
        public Queue active = new Queue();
        public Queue history = new Queue();
        public Queue logbook = new Queue();
        public Call(string callIdentifier)
        {
            this.callIdentifier = callIdentifier;
        }
        //Bekleme sırasına çağrı ekle
        public void addCall(string ID,string Name,string Type) 
        {
            active.insert(ID,Name,Type,"Sırada","-");

        }
        //Çağrı bitir
        public void endCall(string ID,string Name,string Type)
        {
            endDate = DateTime.UtcNow.ToString("HH:mm\ndd-MM-yyyy");
            history.insert(ID,Name,Type,startDate,endDate);
            callState = false;
            callCount++;
        }
        //Sıradan çağrı al
        public void startCall()
        {
            active.delete();
            startDate = DateTime.UtcNow.ToString("HH:mm\ndd-MM-yyyy");
            callState = true;
        }
        //Özel arama al
        public Node special;
        public void specialCall(int position)
        {
            special=  active.list.getNode(position);
            active.list.deletePosition(position);
            startDate = DateTime.UtcNow.ToString("HH:mm\ndd-MM-yyyy");
            callCount++;
        }
        //Özel aramayı bitir
        public void endSpecialCall()
        {
            endCall(special.ID,special.Name,special.nType);
        }
        
    }
}