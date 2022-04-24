using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çağrı_Merkezi_Uygulaması
{
    public class Sorting
    {
        List<Client> clients = new List<Client>();
        string type;
        public Sorting(string type,List<Client> clients)
        {
            this.type = type;
            this.clients = clients;
        }
        //Sıralama tipine göre işlem gerçekleştir
        public List<Client> sort()
        {
          switch(type)
            {
                case "Ada göre":
                    return toName();
                case "ID numarasına göre":
                    return toID();
                case "Ticari görüşmeleri öne al":
                    return commerical();
                default:
                    return individual();
            }
        }
        //BUBBLE SHORT ile isme göre sırala
        public List<Client> toName()
        {
            List<Client> clients = this.clients;
            for(int i=0;i<clients.Count;i++)
            {
                for(int j = 0;j<clients.Count-i-1;j++)
                {
                    int check = String.Compare(clients[j].fullName, clients[j + 1].fullName);
                    if(check>0)
                    {
                        Client c = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j+1] = c;
                    }
                }
            }
            return clients;
        }
        //SELECTION SORT ile ID göre sırala
        public List<Client> toID()
        {
            List<Client> clients = this.clients;
            for ( int i = 0; i<clients.Count;i++)
            {
                int lower = Convert.ToInt32(clients[i].ID);
                int storedIndex = i;
                for (int j = i+1;j<clients.Count;j++)
                {
                    int check = Convert.ToInt32(clients[j].ID);
                    if(lower>check)
                    {
                        lower = check;
                        storedIndex = j;
                    }
                }
                Client c = clients[storedIndex];
                clients[storedIndex] = clients[i];
                clients[i] = c;   
            }
            
            return clients;
        }
        //Ticari görüşmeleri önemse (öne al)
        public List<Client> commerical()
        {
            List<Client> clients = this.clients;
            int length = clients.Count;
            bool isOddNumber = false;
            if (length % 2 == 0)
                isOddNumber = true;
            if(isOddNumber)
            {
                int middle = length /2;
                for (int i = 0; i < middle; i++)
                    if (clients[i].clientType == "Bireysel Müşteri")
                    {
                        Client c = clients[i];
                        clients[i] = clients[length - i-1];
                        clients[length- i-1] = c;
                    }
            }
            else
            {
                int middle = length / 2;
                for(int i = 0;i<middle;i++)
                    if(clients[i].clientType=="Bireysel Müşteri")
                    {
                        Client c = clients[i];
                        clients[i] = clients[length - i-1];
                        clients[length - i-1] = c;
                    }
            }
            return clients;
        }
        //Bireysel görüşmeleri önemse (öne al)
        public List<Client> individual()
        {
            List<Client> clients = this.clients;
            int length = clients.Count;
            bool isOddNumber = false;
            if (length % 2 == 0)
                isOddNumber = true;
            if (isOddNumber)
            {
                int middle =length/2;
                for (int i = 0; i < middle; i++)
                    if (clients[i].clientType == "Ticari Müşteri")
                    {
                        Client c = clients[i];
                        clients[i] = clients[length - i-1];
                        clients[length - i-1] = c;
                    }
            }
            else
            {
                int middle = (length + 1) / 2;
                for (int i = 0; i < middle; i++)
                    if (clients[i].clientType == "Ticari Müşteri")
                    {
                        Client c = clients[i];
                        clients[i] = clients[length - i-1];
                        clients[length - i-1] = c;
                    }
            }
            return clients;
        }

    }
}
