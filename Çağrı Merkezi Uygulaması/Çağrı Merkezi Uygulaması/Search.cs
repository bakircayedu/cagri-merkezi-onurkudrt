using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
  public  class Search
    {
        List<Client> clients = new List<Client>();
        public Search(List<Client> clients)
        {
            this.clients = clients;
        }
        //ID ara 
        public Client linearSearch(string ID)
        {
            Client c = new Client(ID,"","");
            for(int counter=0;counter<clients.Count;counter++)
            {
                if (clients[counter].ID == ID) return clients[counter];
            }
            return c;
        }
        //ID nin varlığını kontrol et
        public bool isAvaible(string ID)
        {
            Client c = linearSearch(ID);
            if (c.fullName == "") return false;
            else return true;
        }
        //İsim ara
        public List<Client> searchName(string Name)
        {
            List<Client> list = new List<Client>();
            for(int i = 0; i<clients.Count;i++)
            {
                if (clients[i].fullName == Name) list.Add(clients[i]);

            }
            return list; 
        }
        public List<Client> searchNotes(string keyWord)
        {
            List<Client> keyClients = new List<Client>();
            if (keyWord == "")
                return keyClients;
            for (int i = 0; i < clients.Count; i++)
            {
                string[] words = clients[i].Note.Split(' ','.','\n');
                for(int j = 0;j<words.Length;j++)
                    if(keyWord == words[j])
                    {
                        keyClients.Add(clients[i]);
                        continue;
                    }
            }
            return keyClients;
        }
    }
}
