using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
  public class Queue
    {
        public int Size = 0;
        public LinkedList list = new LinkedList();
        public Node Tail;
        public Node Head;
        //Kuyruğa eleman ekle (sondan ekleme)
        public void insert(string ID, string Name, string Type,string sTime,string eTime)
        {
            list.insertLast(ID, Name, Type,sTime,eTime);
            findHead();
            findTail();
            Size++;
        }
        //Kuyruktan eleman çıkar (baştan silme)
        public void delete()
        {
            list.deleteFirst();
            findHead();
            findTail();
            Size--;
        }
        //Kuyruktan eleman getir
        public string getElement(int position)
        { 
          return list.getElement(position);
        }
        //Bütün listeyi (kuyruğu) görüntüle
        public string allList()
        {
            return list.DisplayElements();
        }
        //Kuyruk sonunu bul
        public void findTail()
        {
            findHead();
            Node temp = Head;
            if(temp!= null)
            {
                while (temp.Next != null)
                    temp = temp.Next;
                Tail = temp;
            }
            else
            {
                Tail = null;
            }
                
        }
        //Kuyruk başını bul
        public void findHead()
        {
            if (list.Head == null)
                Head = null;
            else
            Head = list.Head;
        }
        //Kuyruğun başını getir
        public string getHead()
        {
            Head = list.Head;
            string temp ="ID: "+Head.ID+"\nİsim: "+Head.Name+"\nTip: "+Head.nType;
            return temp;
        }
        //Sondaki elemanı getir
        public string getTail()
        {
            findTail();
            string temp ="ID: "+Tail.ID +"\nİsim: "+Tail.Name+"\nTip: "+Tail.nType;
            return temp;
        }
        //Kuyruğun boş olup olmadığını kontol et
        public bool isEmpty ()
        {
            return list.IsEmpty();
        }
    }
}

