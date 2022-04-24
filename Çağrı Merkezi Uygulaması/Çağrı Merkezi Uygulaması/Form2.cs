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
    public partial class Form2 : Form
    {
        public CommericalPersonal cPersonal;
        public IndividualPersonal iPersonal;
        bool chooseCommerical;
        string clientName, clientID;
        //Seçili olan temsilcinin ve müşterilerinin forma taşınması ayrıca yapılan çağrı tipi bool olarak temsil edilir
        public Form2(IndividualPersonal personal, string clientName, string clientID)
        {
            InitializeComponent();
            iPersonal = personal;
            chooseCommerical = false;
            this.clientName = clientName;
            this.clientID = clientID;
        }
        public Form2(CommericalPersonal personal, string clientName, string clientID)
        {
            InitializeComponent();
            cPersonal = personal;
            chooseCommerical = true;
            this.clientName = clientName;
            this.clientID = clientID;
        }
        public Form2()
        {
        //To do..
        }
        //Aranan müşteri için not eklenecekse eğer geçerli alanı görünür hale getiren fonksiyon
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            txtNote.Visible = true;
            btnAdd.Visible = true;
            btnAddNote.Visible = false;
            lblOK.Visible = false;
        }
        //Aranan müşteriye not ekleme algoritması
        private void btnAdd_Click(object sender, EventArgs e)
        {
           string Note =  txtNote.Text;
            if(chooseCommerical)
            {
                cPersonal.addNote(clientID, Note);
                btnAdd.Visible = false;
                btnAddNote.Visible = true;
                txtNote.Visible = false;
                lblOK.Visible = true;
            }
            else
            {
                iPersonal.addNote(clientID, Note);
                btnAdd.Visible = false;
                btnAddNote.Visible = true;
                txtNote.Visible = false;
                lblOK.Visible = true;
            }
        }
        //Çağrı bitirme algoritması
        private void btnEndCall_Click(object sender, EventArgs e)
        {
            if(chooseCommerical)
            {
                cPersonal.endCall(clientID,clientName);
                this.Close();
               
            }
            else
            {
                iPersonal.endCall(clientID, clientName);
                this.Close();
            }
        }
        //Form yüklendiği sırada çağrı saati ve diğer bilgiler burada saklanır
        private void Form2_Load(object sender, EventArgs e)
        {
            if(chooseCommerical)
            {
                lblClientName.Text = clientName;
                lblClientID.Text = clientID;
                lblPersonalName.Text = cPersonal.fullName;
                lblPersonalID.Text = cPersonal.ID;
                lblCallType.Text = cPersonal.call.callIdentifier;
                lblDate.Text = cPersonal.call.startDate;
            }
            else
            {
                lblClientName.Text = clientName;
                lblClientID.Text = clientID;
                lblPersonalName.Text = iPersonal.fullName;
                lblPersonalID.Text = iPersonal.ID;
                lblCallType.Text = iPersonal.call.callIdentifier;
                lblDate.Text = iPersonal.call.startDate;
            }
        }
    }
}
