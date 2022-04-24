using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Çağrı_Merkezi_Uygulaması
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //Temsilciler için 7 haneli ID atama fonksiyonu
        public int[] randomID()
        {
                Random random = new Random();
            int[] number = new int[4];
            for(int  i =0;i<4;i++)
                while ( number[i]>=9999999 | number[i]<=1000000)
                {
                number[i] = random.Next();
                }   
                return number;
        }

        //Queue logbook = new Queue();
        IndividualPersonal onur;
        IndividualPersonal sezai;
        CommericalPersonal salih;
        CommericalPersonal umit;
        //Bireysel müşteri temsilciler için bir arama dengeleme fonksiyonudur.
        //Bekleyen aramalar sırası uygun (yükü hafif) olan temsilci burada belirlenir.
        //Ona göre çağrı yönlendirilir
        public IndividualPersonal choseI()
        {
            int sizeOnur = onur.call.active.Size;
            int sizeSezai = sezai.call.active.Size;
            if (sizeOnur > sizeSezai)
                return sezai;
            else if (sizeSezai > sizeOnur)
                return onur;
            else
            {
                Random rand = new Random();
                int random = rand.Next();
                if (random > 0) return onur;
                else return sezai;
            }
        }
        //Ticari müşteri temsilciler için bir arama dengeleme fonksiyonudur.
        //Bekleyen aramalar sırası uygun (yükü hafif) olan temsilci burada belirlenir.
        //Ona göre çağrı yönlendirilir
        public CommericalPersonal choseC()
        {
            int sizeSalih = salih.call.active.Size;
            int sizeUmit = umit.call.active.Size;
            if (sizeSalih > sizeUmit)
                return umit;
            else if (sizeUmit > sizeSalih)
                return salih;
            else
            {
                Random rand = new Random();
                int random = rand.Next();
                if (random == 0) return salih;
                else return umit;
            }
        }
        //Yeni bir arama yapmak için kullanılır, müşteri uygun temsilcinin arama sırasına alınır
        private void btnCallStart_Click(object sender, EventArgs e)
        {
            string fullName = txtNameClient.Text;
            string clientType = cboxCallType.Text;
            txtNameClient.Text = "";
            cboxCallType.Text = "";
            Random random = new Random();
            int intID=random.Next();
            while (intID < 100000 | intID > 999999) intID = random.Next();
                string ID=intID.ToString();
            if (fullName != "")
            {
                Client client = new Client(ID, fullName, clientType);

                if (clientType == "Ticari")
                {
                    CommericalPersonal personal = choseC();
                    personal.addCall(ID, fullName);
                    lblAdded.Visible = true;
                }

                else if (clientType == "Bireysel")
                {
                    IndividualPersonal personal = choseI();
                    personal.addCall(ID, fullName);
                    lblAdded.Visible = true;
                }

                else MessageBox.Show("Arama Tipi boş geçilemez! ");
            }

            else MessageBox.Show("Müşteri Adı boş geçilemez! ");

        }
        //Uygulama başlatıldığı anca temsilci sınıflarının oluşturulması ve ID lerin atanması
        private void Form1_Load(object sender, EventArgs e)
        {
            int IDonur, IDsezai, IDsalih, IDumit;
            IDonur = randomID()[0];
            IDsezai = randomID()[1];
            IDsalih = randomID()[2];
            IDumit = randomID()[3];
            onur = new IndividualPersonal("Onur Kudret",IDonur.ToString());
            sezai = new IndividualPersonal("Sezai Yüksel", IDsezai.ToString());
            salih = new CommericalPersonal("Mehmet Salih İnan",IDsalih.ToString());
            umit = new CommericalPersonal("Ümit Yılmaz",IDumit.ToString());
        }
        //Her müşteri temsilcisi için geçerli olan buton işlevleri
        private void btnOnur_Click(object sender, EventArgs e)
        {
            options(cbOnur, onur);
            lblAdded.Visible = false;
        }

        private void btnSezai_Click(object sender, EventArgs e)
        {
            options(cbSezai, sezai);
            lblAdded.Visible = false;
        }

        private void btnMSalih_Click(object sender, EventArgs e)
        {
            options(cbMSalih, salih);
            lblAdded.Visible = false;
        }

        private void btnUmit_Click(object sender, EventArgs e)
        {
            options(cbUmit, umit);
            lblAdded.Visible = false;
        }
        //Ticari müşteri temsilcileri için arama alma
        //NOT: BEKLEYEN ARAMALAR BOŞ İSE ARAMA GERÇEKLEŞTİRİLEMEYECEKTİR.
        public void newCall(CommericalPersonal c)
        {
            Node node = c.call.active.Head;
            if (node == null)
            {
                MessageBox.Show("Bekleyen arama yok. ");
                if (c.fullName == "Mehmet Salih İnan")
                    chSalih.Text = "Çağrı gerçekleştirilemedi.";
                else chUmit.Text = "Çağrı gerçekleştirilemedi.";
            }
            else
            {
                Form2 form2 = new Form2(c, node.Name, node.ID);
                c.newCall();
                form2.Show();
            }
        }
        //Bireysel müşteri temsilcileri için arama alma
        //NOT: BEKLEYEN ARAMALAR BOŞ İSE ARAMA GERÇEKLEŞTİRİLEMEYECEKTİR.
        public void newCall(IndividualPersonal i)
        {
            Node node = i.call.active.Head;
            if (node == null)
            {
                MessageBox.Show("Bekleyen arama yok. ");
                if (i.fullName == "Onur Kudret")
                    chOnur.Text = "Çağrı gerçekleştirilemedi.";
                else chSezai.Text = "Çağrı gerçekleştirilemedi.";
            }
            else
            {
                Form2 form2 = new Form2(i, node.Name, node.ID);
                i.newCall();
                form2.Show();
            }
        }
        //Bireysel müşteri temslcileri için işlem seçimi
        public void options(ComboBox cb,IndividualPersonal i)
        {
            switch (cb.Text)
            {
                case "Yeni Arama":
                    if(i.fullName == "Onur Kudret")
                    {
                        listViewOnur.Items.Clear();
                        chOnur.Text = "Aramada..";
                        newCall(i);
                    }
                    else
                    {
                        listViewSezai.Items.Clear();
                        chSezai.Text = "Aramada..";
                        newCall(i);
                    }
                    break;
                case "Arama Geçmişi":
                    if (i.fullName == "Onur Kudret")
                        chOnur.Text = "Geçmiş";
                    else
                        chSezai.Text = "Geçmiş";
                    callHistory(i);
                    break;
                case "Temsilci Hakkında":
                    personalInformation(i);
                    break;
                case "Bekleyen Aramalar":
                    pendingCalls(i);
                    break;
                default:
                    MessageBox.Show("Yapmak istediğiniz işlemi seçiniz.");
                    break;
            }
        }
        //Ticari müşteri temsilcileri için işlem seçimi
        public void options(ComboBox cb, CommericalPersonal c)
        {
            switch (cb.Text)
            {
                case "Yeni Arama":
                    if (c.fullName == "Mehmet Salih İnan")
                    {
                        listViewOnur.Items.Clear();
                        chSalih.Text = "Aramada..";
                        newCall(c);
                    }
                    else
                    {
                        listViewSezai.Items.Clear();
                        chUmit.Text = "Aramada..";
                        newCall(c);
                    }
                    break;
                case "Arama Geçmişi":
                    if (c.fullName == "Mehmet Salih İnan")
                        chSalih.Text = "Geçmiş";
                    else
                        chUmit.Text = "Geçmiş";
                    callHistory(c);
                    break;
                case "Temsilci Hakkında":
                    personalInformation(c);
                    break;
                case "Bekleyen Aramalar":
                    pendingCalls(c);
                    break;
                default:
                    MessageBox.Show("Yapmak istediğiniz işlemi seçiniz.");
                    break;
            }
        }
        //Bireysel müşteri temsilcileri için arama geçmişini görüntüleme
        public void callHistory(IndividualPersonal p)
        {
            string[] temp = p.showCallHistory().Split('\n');
            if (p.fullName == "Onur Kudret")
            {
                listViewOnur.Items.Clear();
                for (int a = 0; a < temp.Length; a++)
                    listViewOnur.Items.Add(temp[a]);
            }
            else
            {
                listViewSezai.Items.Clear();
                for (int a = 0; a < temp.Length; a++)
                    listViewSezai.Items.Add(temp[a]);
            }
        }
        //Ticari müşteri temsilcileri için arama geçmişini görüntüleme
        public void callHistory(CommericalPersonal p)
        {
            string[] temp= p.showCallHistory().Split('\n');
            if (p.fullName == "Mehmet Salih İnan")
            {
                listViewSalih.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewSalih.Items.Add(temp[i]);
            }
            else
            {
                listViewUmit.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewUmit.Items.Add(temp[i]);
            }
        }
        //Bireysel müşteri temsilcileri hakkında bilgileri görüntüleme
        public void personalInformation(IndividualPersonal p) 
        {
            string[] data = new string[4];
            data[0] = "ID: " + p.ID;
            data[1] = "Adı: " + p.fullName;
            data[2] = "Birim: " +p.workUnit;
            data[3] = "Müşteri Sayısı: " + p.clientCounter;
            if (p.fullName == "Onur Kudret")
            {
                chOnur.Text = "Temsilci Hakkında";
                listViewOnur.Items.Clear();
                for(int j = 0;j<4;j++)
                listViewOnur.Items.Add(data[j]);
            }
            else
            {
                chSezai.Text = "Temsilci Hakkında";
                listViewSezai.Items.Clear();
                for (int j = 0; j < 4; j++)
                    listViewSezai.Items.Add(data[j]);
            }
        }
        //Ticari müşteri temsilcileri hakkında bilgleri görüntüleme
        public void personalInformation(CommericalPersonal p)
        {
            string[] data = new string[4];
            data[0] = "ID: " + p.ID;
            data[1] = "Adı: " + p.fullName;
            data[2] = "Birim: " + p.workUnit;
            data[3] = "Müşteri Sayısı: " + p.clientCounter;
            if (p.fullName == "Ümit Yılmaz")
            {
                chUmit.Text = "Temsilci Hakkında";
                listViewUmit.Items.Clear();
                for (int j = 0; j < 4; j++)
                    listViewUmit.Items.Add(data[j]);
            }
            else
            {
                chSalih.Text = "Temsilci Hakkında";
                listViewSalih.Items.Clear();
                for (int j = 0; j < 4; j++)
                    listViewSalih.Items.Add(data[j]);
            }
        }
        //Bireysel müşteri temsilcileri için bekleyen aramaları görüntüle
        public void pendingCalls(IndividualPersonal p)
        {
            string[] temp = p.call.active.allList().Split('\n');
            if (p.fullName == "Onur Kudret")
            {
                chOnur.Text = "Sıradakiler";
                listViewOnur.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewOnur.Items.Add(temp[i]);
            }
            else
            {
                chSezai.Text = "Sıradakiler";
                listViewSezai.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewSezai.Items.Add(temp[i]);
            }
        }
        //Ticari müşteri temsilcileri için bekleyen aramaları görüntüle
        public void pendingCalls(CommericalPersonal p)
        {
            string[] temp = p.call.active.allList().Split('\n');
            if(p.fullName == "Ümit Yılmaz")
            {
                chUmit.Text = "Sıradakiler";
                listViewUmit.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewUmit.Items.Add(temp[i]);
            }
            else
            {
                chSalih.Text = "Sıradakiler";
                listViewSalih.Items.Clear();
                for (int i = 0; i < temp.Length; i++)
                    listViewSalih.Items.Add(temp[i]);
            }
        }
        //Müşteriler hakkında bilgilere erişim penceresi
        private void btnShow_Click(object sender, EventArgs e)
        {
            IndividualPersonal[] i = { onur, sezai };
            CommericalPersonal[] c = { umit, salih };
            Form3 form3 = new Form3(i,c);
            form3.Show();
        }

        private void gbSorting_Enter(object sender, EventArgs e)
        {

        }
        //Yaklaşık 50 örnek veriyi müşteri temsilcilerine yönlendir (bekleyen aramalar olarak)
        private void button1_Click(object sender, EventArgs e)
        {
            string b = "Bireysel";
            string t = "Ticari";
            example("Ulaş Deniz", b);
            example("Taha Mert Çığırtkan", t);
            example("Hamit Aydın", t);
            example("Özde Acarkan", b);
            example("Atahan	Adanır", b);
            example("Ecren Baldo", t);
            example("Hacı Mehmet Adıgüzel", b);
            example("Kerime Aydoğan Yozgat", t);
            example("Ziya Doğramacı", b);
            example("Aykanat Ağıroğlu", b);
            example("Lemis Akküt", t);
            example("İbrahim Onat Belge", b);
            example("Fatma Özlem Acar", b);
            example("Doga Elif Delice", t);
            example("Ayşen Aksoy", b);
            example("Senem Aksevim", b);
            example("Tuğçe Atalay", t);
            example("Ateş Aycı", t);
            example("Ecem Hatice Akova", b);
            example("Ahmet Raşit Akoğuz", b);
            example("Sakıp Balıoğlu", t);
            example("Lemis Akküt", b);
            example("Lemya Yılmaz", t);
            example("Osman Yasin Aysan", t);
            example("Zeki Yiğithan Armutcu", b);
            example("Ahmet Ali Akçam", t);
            example("Berker Akkiray", b);
            example("İclal Akkoyun", b);
            example("Mercan	Bağçivan", t);
            example("Sakıp	Balıoğlu", b);
            example("İlkay Ramazan Ankara", b);
            example("Thomas Aygen", t);
            example("Sera Cansın Azbay", t);
            example("Elif Feyza Ayrım", t);
            example("Fatma Özlem Acar", b);
            example("Ali İsmail Babacan", t);
            example("Adem Ayvacık", t);
            example("Miraç Demırören", t);
            example("Berkay Dazlak", t);
            example("Osman Yasin Aysan", t);
            example("Emre Ayberk Akfırat", b);
            example("Sakıp Balıoğlu", t);
            example("İbrahim Onat Belge", t);
            example("Neva Çuhadar", t);
            example("Ziya Doğramacı", t);
            example("Öget Arif", b);
            example("Yüksel	Balcı", t);
            example("Lemis Akküt", b);
            example("Sakıp Balıoğlu", t);
            example("Elvan Çatal", t);
            example("Bestami Ağırağaç", b);
            example("Yüksel	Balcı", t);
            example("Tahir Kaymak", b);
            example("Ziya Doğramacı", t);
            example("Delal Abdullatif Acar", b);
            example("Uluç Emre Binbay", t);
            example("Bedirhan Lütfü Akşamoğlu", b);
            example("Remzi Bilgi", t);
            example("Öktem Duymuş", b);
            example("Serhat Sağ", b);
        }
        Random random = new Random();
        //Örnek veri oluşturmak için kullanılan fonksiyon
        public void example(string fullName,string clientType)
        {
            string ID;
                int intID = random.Next();
                while (intID < 100000 | intID > 999999) intID = random.Next();
                ID = intID.ToString();
            Client client = new Client(ID, fullName, clientType);
            if (clientType == "Ticari")
            {
                CommericalPersonal personal = choseC();
                personal.addCall(ID, fullName);
                lblAdded.Visible = true;
            }

            else if (clientType == "Bireysel")
            {
                IndividualPersonal personal = choseI();
                personal.addCall(ID, fullName);
                lblAdded.Visible = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string position = txtNumber.Text;
            switch(cbPersonalName.Text)
            {
                case "Onur Kudret":
                    cbPersonalName.Text = "";
                    specialCall(onur,position);
                    break;
                case "Sezai Yüksel":
                    specialCall(sezai, position);
                    cbPersonalName.Text = "";
                    break;
                case "Mehmet Salih İnan":
                    cbPersonalName.Text = "";
                    specialCall(salih, position);
                    break;
                case "Ümit Yılmaz":
                    cbPersonalName.Text = "";
                    specialCall(umit, position);
                    break;
                default: MessageBox.Show("Bir temsilci seçiniz.");
                    break;
            }
            
        }
        public void specialCall(CommericalPersonal p, string pos)
        {
            int number = Convert.ToInt32(pos);
           Node special =  p.specialCall(number);
            Form2 form2 = new Form2(p, special.Name,special.ID);
            form2.Show();
        }
        public void specialCall(IndividualPersonal p, string pos)
        {
            int number = Convert.ToInt32(pos);
            Node special = p.specialCall(number);
            Form2 form2 = new Form2(p, special.Name, special.ID);
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IndividualPersonal[] iP = { onur, sezai };
            CommericalPersonal[] cP = { umit, salih };
            Form4 form4 = new Form4(iP,cP);
            form4.Show();
        }

        private void btnLogbook_Click(object sender, EventArgs e)
        {
            IndividualPersonal[] iP = { onur, sezai };
            CommericalPersonal[] cP = { umit, salih };
            Form5 form5 = new Form5(iP,cP);
            form5.Show();
        }

    }  
}
