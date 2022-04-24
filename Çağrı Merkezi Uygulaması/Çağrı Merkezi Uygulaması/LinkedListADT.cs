using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
   public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void insertFirst(string data,string name, string type,string startTime,string endTime);
        public abstract void insertLast(string data,string name, string type,string startTime,string endTime);
        public abstract string DisplayElements();
        public abstract void deleteFirst();
        public abstract void deleteLast();
        public abstract void insertPosition(int pos,string data,string name,string type,string startTime,string endTime);
        public abstract void deletePosition(int pos);
        public abstract string errorFunction(string err);
        public abstract string getElement(int position);
        public abstract bool IsEmpty();
    }
}


public class Node
{
    public string ID;
    public string Name;
    public string nType;
    public string startTime;
    public string endTime;
    public Node Next;
}