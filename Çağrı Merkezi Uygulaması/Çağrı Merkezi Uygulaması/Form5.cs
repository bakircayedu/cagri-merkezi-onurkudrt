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
    public partial class Form5 : Form
    {
        IndividualPersonal onur;
        IndividualPersonal sezai;
        CommericalPersonal umit;
        CommericalPersonal salih;
        public Form5(IndividualPersonal[] iP,CommericalPersonal[] cP)
        {
            InitializeComponent();
            onur=iP[0];
            sezai = iP[1];
            umit = cP[0];
            salih = cP[1];
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showLogbook();
        }
        public void showLogbook()
        {
            listViewLogbook.Items.Clear();
            List<string[]> logbook = prepareLogbook();
            int counter = 0;
            for(int i =0;i<logbook.Count-1;i++)
            {
                listViewLogbook.Items.Add("Müşteri temsilcisi: "+logbook[4][counter]+" için arama kayıtları."+"\n\n");
                for (int j = 0; j < logbook[i].Length; j++)
                    listViewLogbook.Items.Add(logbook[i][j]);
                listViewLogbook.Items.Add("\n\n\n");
                counter++;
            }

          
        }
        public List<string[]> prepareLogbook()
        {
            string[] temp = new string[4];
            temp[0] = onur.call.history.allList();
            temp[1] = sezai.call.history.allList();
            temp[2]= umit.call.history.allList();
            temp[3]= salih.call.history.allList();
            string[] tempOnur= temp[0].Split('\n');
            string[] tempSezai = temp[1].Split('\n');
            string[] tempUmit = temp[2].Split('\n');
            string[] tempSalih = temp[3].Split('\n');
            List<string[]> list = new List<string[]>();
            list.Add(tempOnur);
            list.Add(tempSezai);
            list.Add(tempUmit);
            list.Add(tempSalih);
            string[] names = { "Onur Kudret", "Sezai Yüksel", "Ümit Yılmaz", "Mehmet Salih İnan" };
            list.Add(names);
            return list;
        }
    }
}
