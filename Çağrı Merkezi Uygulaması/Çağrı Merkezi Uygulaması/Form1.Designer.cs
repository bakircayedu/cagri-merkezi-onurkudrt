
namespace Çağrı_Merkezi_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.btnCallStart = new System.Windows.Forms.Button();
            this.cboxCallType = new System.Windows.Forms.ComboBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listViewUmit = new System.Windows.Forms.ListView();
            this.chUmit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUmit = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewSalih = new System.Windows.Forms.ListView();
            this.chSalih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMSalih = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMSalih = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewSezai = new System.Windows.Forms.ListView();
            this.chSezai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSezai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSezai = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewOnur = new System.Windows.Forms.ListView();
            this.chOnur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOnur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOnur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAdded = new System.Windows.Forms.Label();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnSearchNote = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPersonalName = new System.Windows.Forms.ComboBox();
            this.btnLogbook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbSorting.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCallStart
            // 
            this.btnCallStart.Location = new System.Drawing.Point(74, 83);
            this.btnCallStart.Name = "btnCallStart";
            this.btnCallStart.Size = new System.Drawing.Size(121, 31);
            this.btnCallStart.TabIndex = 0;
            this.btnCallStart.Text = "Arama Yap";
            this.btnCallStart.UseVisualStyleBackColor = true;
            this.btnCallStart.Click += new System.EventHandler(this.btnCallStart_Click);
            // 
            // cboxCallType
            // 
            this.cboxCallType.FormattingEnabled = true;
            this.cboxCallType.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.cboxCallType.Location = new System.Drawing.Point(74, 55);
            this.cboxCallType.Name = "cboxCallType";
            this.cboxCallType.Size = new System.Drawing.Size(121, 21);
            this.cboxCallType.TabIndex = 1;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(74, 25);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(121, 20);
            this.txtNameClient.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxCallType);
            this.groupBox1.Controls.Add(this.txtNameClient);
            this.groupBox1.Controls.Add(this.btnCallStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA YAP (TEST)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arama Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 496);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Temsilcileri";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox6.Controls.Add(this.listViewUmit);
            this.groupBox6.Controls.Add(this.btnUmit);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.cbUmit);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(317, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 230);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ümit Yılmaz";
            // 
            // listViewUmit
            // 
            this.listViewUmit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUmit});
            this.listViewUmit.HideSelection = false;
            this.listViewUmit.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listViewUmit.Location = new System.Drawing.Point(5, 59);
            this.listViewUmit.Name = "listViewUmit";
            this.listViewUmit.Size = new System.Drawing.Size(281, 165);
            this.listViewUmit.TabIndex = 10;
            this.listViewUmit.UseCompatibleStateImageBehavior = false;
            this.listViewUmit.View = System.Windows.Forms.View.Details;
            // 
            // chUmit
            // 
            this.chUmit.Text = "Durum";
            this.chUmit.Width = 276;
            // 
            // btnUmit
            // 
            this.btnUmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUmit.Location = new System.Drawing.Point(185, 30);
            this.btnUmit.Name = "btnUmit";
            this.btnUmit.Size = new System.Drawing.Size(75, 23);
            this.btnUmit.TabIndex = 9;
            this.btnUmit.Text = "Seç";
            this.btnUmit.UseVisualStyleBackColor = true;
            this.btnUmit.Click += new System.EventHandler(this.btnUmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem:";
            // 
            // cbUmit
            // 
            this.cbUmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbUmit.FormattingEnabled = true;
            this.cbUmit.Items.AddRange(new object[] {
            "Yeni Arama",
            "Arama Geçmişi",
            "Temsilci Hakkında",
            "Bekleyen Aramalar"});
            this.cbUmit.Location = new System.Drawing.Point(54, 30);
            this.cbUmit.Name = "cbUmit";
            this.cbUmit.Size = new System.Drawing.Size(125, 23);
            this.cbUmit.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox5.Controls.Add(this.listViewSalih);
            this.groupBox5.Controls.Add(this.btnMSalih);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cbMSalih);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(16, 263);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 230);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mehmet Salih İnan";
            // 
            // listViewSalih
            // 
            this.listViewSalih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSalih});
            this.listViewSalih.HideSelection = false;
            this.listViewSalih.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.listViewSalih.Location = new System.Drawing.Point(7, 59);
            this.listViewSalih.Name = "listViewSalih";
            this.listViewSalih.Size = new System.Drawing.Size(281, 165);
            this.listViewSalih.TabIndex = 8;
            this.listViewSalih.UseCompatibleStateImageBehavior = false;
            this.listViewSalih.View = System.Windows.Forms.View.Details;
            // 
            // chSalih
            // 
            this.chSalih.Text = "Durum";
            this.chSalih.Width = 276;
            // 
            // btnMSalih
            // 
            this.btnMSalih.Location = new System.Drawing.Point(179, 30);
            this.btnMSalih.Name = "btnMSalih";
            this.btnMSalih.Size = new System.Drawing.Size(75, 23);
            this.btnMSalih.TabIndex = 8;
            this.btnMSalih.Text = "Seç";
            this.btnMSalih.UseVisualStyleBackColor = true;
            this.btnMSalih.Click += new System.EventHandler(this.btnMSalih_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "İşlem:";
            // 
            // cbMSalih
            // 
            this.cbMSalih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMSalih.FormattingEnabled = true;
            this.cbMSalih.Items.AddRange(new object[] {
            "Yeni Arama",
            "Arama Geçmişi",
            "Temsilci Hakkında",
            "Bekleyen Aramalar"});
            this.cbMSalih.Location = new System.Drawing.Point(48, 30);
            this.cbMSalih.Name = "cbMSalih";
            this.cbMSalih.Size = new System.Drawing.Size(125, 23);
            this.cbMSalih.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox4.Controls.Add(this.listViewSezai);
            this.groupBox4.Controls.Add(this.btnSezai);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbSezai);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(317, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 235);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sezai Yüksel";
            // 
            // listViewSezai
            // 
            this.listViewSezai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSezai});
            this.listViewSezai.HideSelection = false;
            listViewItem7.IndentCount = 5;
            this.listViewSezai.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7});
            this.listViewSezai.Location = new System.Drawing.Point(4, 61);
            this.listViewSezai.Name = "listViewSezai";
            this.listViewSezai.Size = new System.Drawing.Size(281, 168);
            this.listViewSezai.TabIndex = 5;
            this.listViewSezai.UseCompatibleStateImageBehavior = false;
            this.listViewSezai.View = System.Windows.Forms.View.Details;
            // 
            // chSezai
            // 
            this.chSezai.Text = "Durum";
            this.chSezai.Width = 277;
            // 
            // btnSezai
            // 
            this.btnSezai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSezai.Location = new System.Drawing.Point(185, 28);
            this.btnSezai.Name = "btnSezai";
            this.btnSezai.Size = new System.Drawing.Size(75, 23);
            this.btnSezai.TabIndex = 7;
            this.btnSezai.Text = "Seç";
            this.btnSezai.UseVisualStyleBackColor = true;
            this.btnSezai.Click += new System.EventHandler(this.btnSezai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "İşlem:";
            // 
            // cbSezai
            // 
            this.cbSezai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbSezai.FormattingEnabled = true;
            this.cbSezai.Items.AddRange(new object[] {
            "Yeni Arama",
            "Arama Geçmişi",
            "Temsilci Hakkında",
            "Bekleyen Aramalar"});
            this.cbSezai.Location = new System.Drawing.Point(54, 28);
            this.cbSezai.Name = "cbSezai";
            this.cbSezai.Size = new System.Drawing.Size(125, 23);
            this.cbSezai.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.listViewOnur);
            this.groupBox3.Controls.Add(this.btnOnur);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbOnur);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(16, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 235);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Onur Kudret";
            // 
            // listViewOnur
            // 
            this.listViewOnur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOnur});
            this.listViewOnur.HideSelection = false;
            this.listViewOnur.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8});
            this.listViewOnur.Location = new System.Drawing.Point(6, 61);
            this.listViewOnur.Name = "listViewOnur";
            this.listViewOnur.Size = new System.Drawing.Size(281, 168);
            this.listViewOnur.TabIndex = 7;
            this.listViewOnur.UseCompatibleStateImageBehavior = false;
            this.listViewOnur.View = System.Windows.Forms.View.Details;
            // 
            // chOnur
            // 
            this.chOnur.Text = "Durum";
            this.chOnur.Width = 277;
            // 
            // btnOnur
            // 
            this.btnOnur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOnur.Location = new System.Drawing.Point(179, 32);
            this.btnOnur.Name = "btnOnur";
            this.btnOnur.Size = new System.Drawing.Size(75, 23);
            this.btnOnur.TabIndex = 6;
            this.btnOnur.Text = "Seç";
            this.btnOnur.UseVisualStyleBackColor = true;
            this.btnOnur.Click += new System.EventHandler(this.btnOnur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "İşlem:";
            // 
            // cbOnur
            // 
            this.cbOnur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbOnur.FormattingEnabled = true;
            this.cbOnur.Items.AddRange(new object[] {
            "Yeni Arama",
            "Arama Geçmişi",
            "Temsilci Hakkında",
            "Bekleyen Aramalar"});
            this.cbOnur.Location = new System.Drawing.Point(48, 32);
            this.cbOnur.Name = "cbOnur";
            this.cbOnur.Size = new System.Drawing.Size(125, 23);
            this.cbOnur.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(8, 389);
            this.label7.MaximumSize = new System.Drawing.Size(200, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 112);
            this.label7.TabIndex = 5;
            this.label7.Text = "Arama yapıldığında müşteriler uygun olan temsilcinin bekleme sırasına yönlendiril" +
    "ir.  Temsilciler müsait oldukları zaman \"Yeni Arama\" seçeneği ile sırada bekleye" +
    "nlerden arama alabilirler.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(7, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bilgi:";
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Location = new System.Drawing.Point(12, 154);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(69, 13);
            this.lblAdded.TabIndex = 7;
            this.lblAdded.Text = "+Sıraya alındı";
            this.lblAdded.Visible = false;
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.label10);
            this.gbSorting.Controls.Add(this.btnShow);
            this.gbSorting.Controls.Add(this.label9);
            this.gbSorting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSorting.Location = new System.Drawing.Point(15, 186);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(125, 97);
            this.gbSorting.TabIndex = 10;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Müşteriler";
            this.gbSorting.Enter += new System.EventHandler(this.gbSorting_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.MaximumSize = new System.Drawing.Size(150, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 48);
            this.label10.TabIndex = 11;
            this.label10.Text = "Müşterileri görüntülemek için tıklayın.";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(9, 71);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Görüntüle";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.MaximumSize = new System.Drawing.Size(165, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(9, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "NOT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 307);
            this.label12.MaximumSize = new System.Drawing.Size(200, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 39);
            this.label12.TabIndex = 12;
            this.label12.Text = "Müşteriler penceresini açtıktan sonra gelen aramalar dahil değildir. Dahil etmek " +
    "için pencereyi yeniden kapatıp açın.";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(119, 147);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(75, 36);
            this.btnExample.TabIndex = 13;
            this.btnExample.Text = "Örnek Veri Yükle";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchNote
            // 
            this.btnSearchNote.Location = new System.Drawing.Point(344, 514);
            this.btnSearchNote.Name = "btnSearchNote";
            this.btnSearchNote.Size = new System.Drawing.Size(385, 23);
            this.btnSearchNote.TabIndex = 16;
            this.btnSearchNote.Text = "Not Ara";
            this.btnSearchNote.UseVisualStyleBackColor = true;
            this.btnSearchNote.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(89, 43);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(37, 20);
            this.txtNumber.TabIndex = 17;
            this.txtNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sıra Numarası:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 20;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbPersonalName);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.txtNumber);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(5, 507);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(219, 77);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Özel Çağrı Başlat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Temsilci:";
            // 
            // cbPersonalName
            // 
            this.cbPersonalName.FormattingEnabled = true;
            this.cbPersonalName.Items.AddRange(new object[] {
            "Onur Kudret",
            "Sezai Yüksel",
            "Mehmet Salih İnan",
            "Ümit Yılmaz"});
            this.cbPersonalName.Location = new System.Drawing.Point(65, 17);
            this.cbPersonalName.Name = "cbPersonalName";
            this.cbPersonalName.Size = new System.Drawing.Size(114, 21);
            this.cbPersonalName.TabIndex = 22;
            // 
            // btnLogbook
            // 
            this.btnLogbook.Location = new System.Drawing.Point(344, 544);
            this.btnLogbook.Name = "btnLogbook";
            this.btnLogbook.Size = new System.Drawing.Size(385, 23);
            this.btnLogbook.TabIndex = 22;
            this.btnLogbook.Text = "Seyir Defteri";
            this.btnLogbook.UseVisualStyleBackColor = true;
            this.btnLogbook.Click += new System.EventHandler(this.btnLogbook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(847, 584);
            this.Controls.Add(this.btnLogbook);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnSearchNote);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbSorting);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallStart;
        private System.Windows.Forms.ComboBox cboxCallType;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listViewUmit;
        private System.Windows.Forms.Button btnUmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUmit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewSalih;
        private System.Windows.Forms.Button btnMSalih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMSalih;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewSezai;
        private System.Windows.Forms.Button btnSezai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSezai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewOnur;
        private System.Windows.Forms.Button btnOnur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOnur;
        private System.Windows.Forms.ColumnHeader chSezai;
        private System.Windows.Forms.ColumnHeader chUmit;
        private System.Windows.Forms.ColumnHeader chSalih;
        private System.Windows.Forms.ColumnHeader chOnur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnSearchNote;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbPersonalName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLogbook;
    }
}

