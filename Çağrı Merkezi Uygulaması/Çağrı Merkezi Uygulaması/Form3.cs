using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çağrı_Merkezi_Uygulaması
{
    public partial class Form3 : Form
    {
        List<Client> clients = new List<Client>();
        //Temsilcilerin ve müşterilerin tek bir listede toplanması
        public Form3(IndividualPersonal[] iP,CommericalPersonal[] cP)
        {
            InitializeComponent();
            Personal[] personals = new Personal[4];
            personals[0] = iP[0]; //onur
            personals[1] = iP[1]; //sezai
            personals[2] = cP[0]; //umit
            personals[3] = cP[1]; //salih
            for (int i = 0; i < personals.Length; i++)
                for (int j = 0; j < personals[i].clients.Count; j++)
                    clients.Add(personals[i].clients[j]);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //Müşterileri belirli sıralama koşuluna göre listeleme algoritması
        public void write()
        {
            listViewClients.Items.Clear();
            List<Client> cl = sort();
            List<string> list = new List<string>();
            string[] temp = new string[4];
            for (int i=0;i<cl.Count;i++)
            {
                temp[0] = "ID: " + cl[i].ID;
                temp[1] = "Adı: " + cl[i].fullName;
                temp[2] = "Müşteri Tipi: " + cl[i].clientType;
                temp[3] = "Temsilci Notu: " + cl[i].Note;
                for (int j = 0; j < 4; j++)
                    list.Add(temp[j]);
                list.Add("\n");
            }
            for (int i = 0; i < list.Count; i++)
            {
                listViewClients.Items.Add(list[i]);
            }
        }
        //Listeleme yapılacağında girdi uygunsa işlevleri yerine getirecek fonksiyonu çağıran buton
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbSortType.Text == "")
                MessageBox.Show("Bir sıralama türü seçin");
            else
            {

                write();
                cbSortType.Text = "";
            }
        }
        //Sıralama algoritması
        public List<Client> sort()
        {
            Sorting sorting = new Sorting(cbSortType.Text, clients);
            return sorting.sort(); ;
        }
        //Arama algoritması
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Sisteme kayıtlı adı ya ID numarasını giriniz.");
            else
            {
                listViewSearch.Items.Clear();
                string IDorName = txtSearch.Text;
                txtSearch.Text = "";
                search(IDorName);
            }
        }
        //Arama algoritması (Eğer bir isim girilmişse, o isme ait birden fazla kayıt varsa bütün kayıtları getirecektir.)
        //Örn: Ziya Doğramacı  (birden fazla kaydı vardır)
        public void search(string IDorName)
        {
            char[] array = IDorName.ToCharArray();
            Search search = new Search(clients);
            if(decision(array) == "Name")
            {
               List<Client> c= search.searchName(IDorName);
                if (c.Count == 0) 
                    listViewSearch.Items.Add("Kayıtlı müşteri bulunamadı.");
                else
                write(c);
            }
            else
            {
                Client client = search.linearSearch(IDorName);
                if (client.fullName == "")
                    listViewSearch.Items.Add("Kayıtlı müşteri bulunamadı.");
                else
                {
                    listViewSearch.Items.Add("ID: " + client.ID);
                    listViewSearch.Items.Add("Adı: " + client.fullName);
                    listViewSearch.Items.Add("Müşteri Tipi: " + client.clientType);
                    listViewSearch.Items.Add("Temsilci Notu: " + client.Note);
                }
            }
        }
        //Girdinin İsim mi yoksa bir ID numarası mı olduğuna karar verme algoritmasıdır,
        //Eğer girdi sayı ve harflerden oluşuyorsa diye tüm kontroller yapılmıştır.
        public string decision(char[] array)
        {
            //Bir ID numarası 6 hanelidir
            //Eğer isim 6 haneliyse diğer kontroller gerçekleştirilecektir
            if (array.Length != 6)
                return "Name";
            // ASCII => 48 57 (Numbers)
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 48 | array[i] > 57)
                    return "Name";
            return "ID";
        }
        //Arama algoritmasına çıkan müşteri dizisini ekrana basan algoritma
        public void write(List<Client> c)
        {
            listViewSearch.Items.Clear();
            List<Client> cl = c;
            List<string> list = new List<string>();
            string[] temp = new string[4];
            for (int i = 0; i < cl.Count; i++)
            {
                temp[0] = "ID: " + cl[i].ID;
                temp[1] = "Adı: " + cl[i].fullName;
                temp[2] = "Müşteri Tipi: " + cl[i].clientType;
                temp[3] = "Temsilci Notu: " + cl[i].Note;
                for (int j = 0; j < 4; j++)
                    list.Add(temp[j]);
                list.Add("\n");
            }
            for (int i = 0; i < list.Count; i++)
            {
                listViewSearch.Items.Add(list[i]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbSortType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
