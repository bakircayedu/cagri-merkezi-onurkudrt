using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
   public class LinkedList : LinkedListADT
    {
        //Baştan sil
        public override void deleteFirst()
        {
            if(IsEmpty())
            {
                errorFunction("Bağlantılı liste zaten NULL");
            }
            else
            {
                Head = Head.Next;
                Size--;
            }
        }
        //Sondan sil
        public override void deleteLast()
        {
            if (IsEmpty())
                errorFunction("Linked list is already NULL");
            else
            {
                Node temp = Head;
                while(temp.Next.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next= null;
                Size--;
            }
        }
        //Listenin belirli pozisyonundan eleman sil
        public override void deletePosition(int pos)
        {
            if (pos > Size)
                errorFunction("Stroug position is not available");
            else
            {
                if (pos == 1) deleteFirst();
                else
                {
                    Node temp = Head;
                    for (int i = 1; i < pos - 1; i++)
                        temp = temp.Next;
                    temp.Next = temp.Next.Next;
                    Size--;
                }
            }
        }
        //Elemanları görüntüle
        public override string DisplayElements()
        {
            string temp = "";
            Node node = Head;
            while(node!=null)
            {
                temp +="ID: "+node.ID.ToString()+"\nİsim: "+node.Name+"\nTip: "+node.nType
                    +"\nBaşlangıç: "+node.startTime+"\nBitiş: "+node.endTime+"\n\n";
                node = node.Next;
            }
            return temp;
        }

        //Baştan ekle
        public override void insertFirst(string data, string name, string type,string sTime,string eTime)
        {
            if (IsEmpty())
            {
                Node temp = new Node()
                {
                    ID = data,
                    Name = name,
                    nType = type,
                    startTime = sTime,
                    endTime=eTime
                };
                Head = temp;
                Size++;
            }
            else
            {
                Node temp = new Node()
                {
                    ID = data,
                    Name=name,
                    nType=type,
                    startTime=sTime,
                    endTime=eTime
                };
                temp.Next = Head;
                Head = temp;
                Size++;
            }
        }
        //Sondan ekle
        public override void insertLast(string data, string name, string type, string sTime, string eTime)
        {
            if (IsEmpty())
                insertFirst(data, name, type,sTime,eTime);
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                Node newNode = new Node()
                {
                    ID = data,
                    Name = name,
                    nType = type,
                    startTime=sTime,
                    endTime=eTime
                };
               temp.Next = newNode;
                Size++;
            }
        }        
        //Belirli bir noktaya eleman ekle
        public override void insertPosition(int pos, string data , string name, string type, string sTime, string eTime)
        {
            if (pos > Size + 1)
                errorFunction("The size of LinkedList isn't enough");
            else
            {
                if (pos == 1)
                    insertFirst(data,name,type,sTime,eTime);
                else
                {
                    Node temp = Head;
                    for (int i = 1; i < pos - 1; i++)
                        temp = temp.Next;
                    Node node = new Node()
                    {
                        ID = data,
                        Name = name,
                        nType = type,
                        startTime=sTime,
                        endTime=eTime,
                        Next = temp.Next
                    };
                    temp.Next = node;
                    Size++;
                }
            }
        }
        //Listenin belirli pozisyonundan eleman getir
        public override string getElement(int position)
        {
           if(position>Size)
            {
                return errorFunction("Sought position is not available.");
            }
            else
            {
                Node temp = Head;
                for (int i = 1; i < position; i++)
                    temp = temp.Next;
                string Ret ="ID: "+temp.ID.ToString() +"\nİsim: "+temp.Name +"\nTip: "+temp.nType
                    +"\nBaşlangıç: "+temp.startTime+"\nBitiş: "+temp.endTime;
                return Ret;
            }
        }
        //Belli bir düğümü getirir
        public Node getNode(int position)
        {
            if (position > Size)
            {
                return null;
            }
            else
            {
                Node temp = Head;
                for (int i = 1; i < position; i++)
                    temp = temp.Next;
                return temp;
            }
        }
        //Hata döndür
        public override string errorFunction(string err)
        {
            return err;
        }
        //Boş olup olmadığına karar ver
        public override bool IsEmpty()
        {
            bool result = false;
            if (Head == null)
                result = true;
            return result;
        }
    }
}
