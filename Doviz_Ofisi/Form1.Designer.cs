
namespace Doviz_Ofisi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaliş = new System.Windows.Forms.Label();
            this.lblDsatiş = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEsatiş = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEaliş = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnişlem1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textMik = new System.Windows.Forms.TextBox();
            this.textKur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btndolar1 = new System.Windows.Forms.Button();
            this.btndolar2 = new System.Windows.Forms.Button();
            this.btneuro1 = new System.Windows.Forms.Button();
            this.btnEuro2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnİşlem2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textmik2 = new System.Windows.Forms.TextBox();
            this.textkalan2 = new System.Windows.Forms.TextBox();
            this.textkur2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.texttutar2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbltürkmiktar = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbldolarmik = new System.Windows.Forms.Label();
            this.lbleuromiktar = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.türkLirasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDövizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDövizDataSet = new Doviz_Ofisi.DbDövizDataSet();
            this.tbl_DövizTableAdapter = new Doviz_Ofisi.DbDövizDataSetTableAdapters.Tbl_DövizTableAdapter();
            this.dbDövizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDövizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDövizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDövizDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // lblDaliş
            // 
            this.lblDaliş.AutoSize = true;
            this.lblDaliş.BackColor = System.Drawing.Color.White;
            this.lblDaliş.Location = new System.Drawing.Point(192, 47);
            this.lblDaliş.Name = "lblDaliş";
            this.lblDaliş.Size = new System.Drawing.Size(30, 34);
            this.lblDaliş.TabIndex = 1;
            this.lblDaliş.Text = "0";
            // 
            // lblDsatiş
            // 
            this.lblDsatiş.AutoSize = true;
            this.lblDsatiş.BackColor = System.Drawing.Color.White;
            this.lblDsatiş.Location = new System.Drawing.Point(192, 95);
            this.lblDsatiş.Name = "lblDsatiş";
            this.lblDsatiş.Size = new System.Drawing.Size(30, 34);
            this.lblDsatiş.TabIndex = 3;
            this.lblDsatiş.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satış:";
            // 
            // lblEsatiş
            // 
            this.lblEsatiş.AutoSize = true;
            this.lblEsatiş.BackColor = System.Drawing.Color.White;
            this.lblEsatiş.Location = new System.Drawing.Point(192, 212);
            this.lblEsatiş.Name = "lblEsatiş";
            this.lblEsatiş.Size = new System.Drawing.Size(30, 34);
            this.lblEsatiş.TabIndex = 7;
            this.lblEsatiş.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satış:";
            // 
            // lblEaliş
            // 
            this.lblEaliş.AutoSize = true;
            this.lblEaliş.BackColor = System.Drawing.Color.White;
            this.lblEaliş.Location = new System.Drawing.Point(192, 164);
            this.lblEaliş.Name = "lblEaliş";
            this.lblEaliş.Size = new System.Drawing.Size(30, 34);
            this.lblEaliş.TabIndex = 5;
            this.lblEaliş.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 34);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alış:";
            // 
            // btnişlem1
            // 
            this.btnişlem1.Location = new System.Drawing.Point(36, 224);
            this.btnişlem1.Name = "btnişlem1";
            this.btnişlem1.Size = new System.Drawing.Size(160, 37);
            this.btnişlem1.TabIndex = 8;
            this.btnişlem1.Text = "Bozdur";
            this.btnişlem1.UseVisualStyleBackColor = true;
            this.btnişlem1.Click += new System.EventHandler(this.btnSatişYap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textMik);
            this.groupBox1.Controls.Add(this.textKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnişlem1);
            this.groupBox1.Controls.Add(this.textTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(28, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Euro/Dolar Bozdurma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "€/$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 34);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tutar:";
            // 
            // textMik
            // 
            this.textMik.Location = new System.Drawing.Point(111, 104);
            this.textMik.Name = "textMik";
            this.textMik.Size = new System.Drawing.Size(224, 41);
            this.textMik.TabIndex = 12;
            // 
            // textKur
            // 
            this.textKur.Location = new System.Drawing.Point(111, 57);
            this.textKur.Name = "textKur";
            this.textKur.Size = new System.Drawing.Size(224, 41);
            this.textKur.TabIndex = 10;
            this.textKur.TextChanged += new System.EventHandler(this.textKur_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 34);
            this.label9.TabIndex = 11;
            this.label9.Text = "Miktar:";
            // 
            // textTutar
            // 
            this.textTutar.Location = new System.Drawing.Point(111, 153);
            this.textTutar.Name = "textTutar";
            this.textTutar.Size = new System.Drawing.Size(224, 41);
            this.textTutar.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 34);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kur :";
            // 
            // btndolar1
            // 
            this.btndolar1.Location = new System.Drawing.Point(297, 47);
            this.btndolar1.Name = "btndolar1";
            this.btndolar1.Size = new System.Drawing.Size(55, 34);
            this.btndolar1.TabIndex = 13;
            this.btndolar1.Text = "...";
            this.btndolar1.UseVisualStyleBackColor = true;
            this.btndolar1.Click += new System.EventHandler(this.btndolar1_Click);
            // 
            // btndolar2
            // 
            this.btndolar2.Location = new System.Drawing.Point(297, 87);
            this.btndolar2.Name = "btndolar2";
            this.btndolar2.Size = new System.Drawing.Size(55, 34);
            this.btndolar2.TabIndex = 14;
            this.btndolar2.Text = "...";
            this.btndolar2.UseVisualStyleBackColor = true;
            this.btndolar2.Click += new System.EventHandler(this.btndolar2_Click);
            // 
            // btneuro1
            // 
            this.btneuro1.Location = new System.Drawing.Point(297, 163);
            this.btneuro1.Name = "btneuro1";
            this.btneuro1.Size = new System.Drawing.Size(55, 34);
            this.btneuro1.TabIndex = 15;
            this.btneuro1.Text = "...";
            this.btneuro1.UseVisualStyleBackColor = true;
            this.btneuro1.Click += new System.EventHandler(this.btneuro1_Click);
            // 
            // btnEuro2
            // 
            this.btnEuro2.Location = new System.Drawing.Point(297, 203);
            this.btnEuro2.Name = "btnEuro2";
            this.btnEuro2.Size = new System.Drawing.Size(55, 34);
            this.btnEuro2.TabIndex = 16;
            this.btnEuro2.Text = "...";
            this.btnEuro2.UseVisualStyleBackColor = true;
            this.btnEuro2.Click += new System.EventHandler(this.btnEuro2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblEaliş);
            this.groupBox2.Controls.Add(this.btnEuro2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btneuro1);
            this.groupBox2.Controls.Add(this.lblDaliş);
            this.groupBox2.Controls.Add(this.btndolar2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btndolar1);
            this.groupBox2.Controls.Add(this.lblDsatiş);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblEsatiş);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(34, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 280);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnİşlem2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textmik2);
            this.groupBox3.Controls.Add(this.textkalan2);
            this.groupBox3.Controls.Add(this.textkur2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.texttutar2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(459, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 280);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Euro/Dolar Alma";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 34);
            this.label11.TabIndex = 25;
            this.label11.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 34);
            this.label7.TabIndex = 19;
            this.label7.Text = "€/$";
            // 
            // btnİşlem2
            // 
            this.btnİşlem2.Location = new System.Drawing.Point(24, 224);
            this.btnİşlem2.Name = "btnİşlem2";
            this.btnİşlem2.Size = new System.Drawing.Size(145, 37);
            this.btnİşlem2.TabIndex = 18;
            this.btnİşlem2.Text = "Al";
            this.btnİşlem2.UseVisualStyleBackColor = true;
            this.btnİşlem2.Click += new System.EventHandler(this.btnİşlem2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 34);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tutar:";
            // 
            // textmik2
            // 
            this.textmik2.Location = new System.Drawing.Point(111, 81);
            this.textmik2.Name = "textmik2";
            this.textmik2.Size = new System.Drawing.Size(224, 41);
            this.textmik2.TabIndex = 12;
            // 
            // textkalan2
            // 
            this.textkalan2.Location = new System.Drawing.Point(111, 177);
            this.textkalan2.Name = "textkalan2";
            this.textkalan2.Size = new System.Drawing.Size(224, 41);
            this.textkalan2.TabIndex = 15;
            // 
            // textkur2
            // 
            this.textkur2.Location = new System.Drawing.Point(111, 34);
            this.textkur2.Name = "textkur2";
            this.textkur2.Size = new System.Drawing.Size(224, 41);
            this.textkur2.TabIndex = 10;
            this.textkur2.TextChanged += new System.EventHandler(this.textkur2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 34);
            this.label14.TabIndex = 11;
            this.label14.Text = "Miktar:";
            // 
            // texttutar2
            // 
            this.texttutar2.Location = new System.Drawing.Point(111, 130);
            this.texttutar2.Name = "texttutar2";
            this.texttutar2.Size = new System.Drawing.Size(224, 41);
            this.texttutar2.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 34);
            this.label15.TabIndex = 14;
            this.label15.Text = "Kalan:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 34);
            this.label16.TabIndex = 10;
            this.label16.Text = "Kur :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lbltürkmiktar);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lbldolarmik);
            this.groupBox4.Controls.Add(this.lbleuromiktar);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(459, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 189);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "KASA";
            // 
            // lbltürkmiktar
            // 
            this.lbltürkmiktar.AutoSize = true;
            this.lbltürkmiktar.BackColor = System.Drawing.Color.White;
            this.lbltürkmiktar.Location = new System.Drawing.Point(280, 137);
            this.lbltürkmiktar.Name = "lbltürkmiktar";
            this.lbltürkmiktar.Size = new System.Drawing.Size(30, 34);
            this.lbltürkmiktar.TabIndex = 5;
            this.lbltürkmiktar.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(66, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 34);
            this.label18.TabIndex = 0;
            this.label18.Text = "Dolar Miktar :";
            // 
            // lbldolarmik
            // 
            this.lbldolarmik.AutoSize = true;
            this.lbldolarmik.BackColor = System.Drawing.Color.White;
            this.lbldolarmik.Location = new System.Drawing.Point(280, 34);
            this.lbldolarmik.Name = "lbldolarmik";
            this.lbldolarmik.Size = new System.Drawing.Size(30, 34);
            this.lbldolarmik.TabIndex = 1;
            this.lbldolarmik.Text = "0";
            // 
            // lbleuromiktar
            // 
            this.lbleuromiktar.AutoSize = true;
            this.lbleuromiktar.BackColor = System.Drawing.Color.White;
            this.lbleuromiktar.Location = new System.Drawing.Point(280, 82);
            this.lbleuromiktar.Name = "lbleuromiktar";
            this.lbleuromiktar.Size = new System.Drawing.Size(30, 34);
            this.lbleuromiktar.TabIndex = 3;
            this.lbleuromiktar.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(66, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(169, 34);
            this.label22.TabIndex = 4;
            this.label22.Text = "Euro Miktar :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(67, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 34);
            this.label24.TabIndex = 6;
            this.label24.Text = "Türl Lirası :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.türkLirasıDataGridViewTextBoxColumn,
            this.euroDataGridViewTextBoxColumn,
            this.dolarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDövizBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(459, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 70);
            this.dataGridView1.TabIndex = 23;
            // 
            // türkLirasıDataGridViewTextBoxColumn
            // 
            this.türkLirasıDataGridViewTextBoxColumn.DataPropertyName = "TürkLirası";
            this.türkLirasıDataGridViewTextBoxColumn.HeaderText = "TürkLirası";
            this.türkLirasıDataGridViewTextBoxColumn.Name = "türkLirasıDataGridViewTextBoxColumn";
            // 
            // euroDataGridViewTextBoxColumn
            // 
            this.euroDataGridViewTextBoxColumn.DataPropertyName = "Euro";
            this.euroDataGridViewTextBoxColumn.HeaderText = "Euro";
            this.euroDataGridViewTextBoxColumn.Name = "euroDataGridViewTextBoxColumn";
            // 
            // dolarDataGridViewTextBoxColumn
            // 
            this.dolarDataGridViewTextBoxColumn.DataPropertyName = "Dolar";
            this.dolarDataGridViewTextBoxColumn.HeaderText = "Dolar";
            this.dolarDataGridViewTextBoxColumn.Name = "dolarDataGridViewTextBoxColumn";
            // 
            // tblDövizBindingSource
            // 
            this.tblDövizBindingSource.DataMember = "Tbl_Döviz";
            this.tblDövizBindingSource.DataSource = this.dbDövizDataSet;
            // 
            // dbDövizDataSet
            // 
            this.dbDövizDataSet.DataSetName = "DbDövizDataSet";
            this.dbDövizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DövizTableAdapter
            // 
            this.tbl_DövizTableAdapter.ClearBeforeFill = true;
            // 
            // dbDövizDataSetBindingSource
            // 
            this.dbDövizDataSetBindingSource.DataSource = this.dbDövizDataSet;
            this.dbDövizDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Tablosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDövizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDövizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDövizDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaliş;
        private System.Windows.Forms.Label lblDsatiş;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEsatiş;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEaliş;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnişlem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMik;
        private System.Windows.Forms.TextBox textKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btndolar1;
        private System.Windows.Forms.Button btndolar2;
        private System.Windows.Forms.Button btneuro1;
        private System.Windows.Forms.Button btnEuro2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnİşlem2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textmik2;
        private System.Windows.Forms.TextBox textkalan2;
        private System.Windows.Forms.TextBox textkur2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox texttutar2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltürkmiktar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbldolarmik;
        private System.Windows.Forms.Label lbleuromiktar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private DbDövizDataSet dbDövizDataSet;
        private System.Windows.Forms.BindingSource tblDövizBindingSource;
        private DbDövizDataSetTableAdapters.Tbl_DövizTableAdapter tbl_DövizTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn türkLirasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn euroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dbDövizDataSetBindingSource;
    }
}

