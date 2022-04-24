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
    public partial class Form4 : Form
    {
        IndividualPersonal onur;
        IndividualPersonal sezai;
        CommericalPersonal salih;
        CommericalPersonal umit;
        public Form4(IndividualPersonal[] iP, CommericalPersonal[] cP)
        {
            InitializeComponent();
            onur = iP[0];
            sezai = iP[1];
            umit = cP[0];
            salih = cP[1];
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //Notlarında anahtar kelimeyi içeren anahtar müşterileri tespit eder
        public List<Client> findKeyClients
            ()
        {
            IndividualPersonal[] iP = { onur, sezai };
            CommericalPersonal[] cP = { umit, salih };
            List<Client> allClients = allClientsFunction();
            Search search = new Search(allClients);
            return search.searchNotes(txtNote.Text);
        }
        //Bütün Müşterileri tek bir listede toplamak için kullanılan fonksiyon
        public List<Client> allClientsFunction()
        {
            List<Client> allClients = new List<Client>();
            Personal[] personals = new Personal[4];
            personals[0] = onur;
            personals[1] = sezai; 
            personals[2] = umit; 
            personals[3] = salih; 
            for (int i = 0; i < personals.Length; i++)
                for (int j = 0; j < personals[i].clients.Count; j++)
                    allClients.Add(personals[i].clients[j]);
            return allClients;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showNotes();
        }
        //Tespit edilen müşterileri listeler
        public void showNotes()
        {
            listViewResults.Items.Clear();
            List<Client> keyClients = findKeyClients();
            if(keyClients.Count == 0)
                listViewResults.Items.Add("Anahtar kelimeyi içeren sonuç bulunamadı.");
            else
            for (int i = 0; i < keyClients.Count; i++)
            {
                string[] temp = new string[5];
                temp[0] = "ID: " + keyClients[i].ID;
                temp[1] = "Adı: " + keyClients[i].fullName;
                temp[2] = "Müşteri Türü: " + keyClients[i].clientType;
                temp[3] = "Temsilci Notu: " + keyClients[i].Note;
                temp[4] = "\n\n";
                for (int j = 0; j < 5; j++)
                    listViewResults.Items.Add(temp[j]);
            }
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
