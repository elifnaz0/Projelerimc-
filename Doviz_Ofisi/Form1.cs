using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;


namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=DbDöviz;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaraliş = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDaliş.Text = dolaraliş;

            string dolarsatiş = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDsatiş.Text = dolarsatiş;

            string euroaliş = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEaliş.Text = euroaliş;

            string eurosatiş = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEsatiş.Text = eurosatiş;

            bgl.Open();
            SqlCommand kasa = new SqlCommand("Select * From Tbl_Döviz where ID=1",bgl);
            SqlDataReader dr = kasa.ExecuteReader();
            while (dr.Read())
            {
                lbltürkmiktar.Text = dr[1].ToString();
                lbleuromiktar.Text = dr[2].ToString();
                lbldolarmik.Text = dr[3].ToString();
            }
            bgl.Close();
        }

        private void btndolar1_Click(object sender, EventArgs e)
        {
            textKur.Text = lblDaliş.Text;
            textkur2.Text = lblDaliş.Text;
        }

        private void btndolar2_Click(object sender, EventArgs e)
        {
            textKur.Text = lblDsatiş.Text;
            textkur2.Text = lblDsatiş.Text;
        }

        private void btneuro1_Click(object sender, EventArgs e)
        {
            textKur.Text = lblEaliş.Text;
            textkur2.Text = lblEaliş.Text;
        }

        private void btnEuro2_Click(object sender, EventArgs e)
        {
            textKur.Text = lblEsatiş.Text;
            textkur2.Text = lblEsatiş.Text;
        }
        public double kur, miktar, tutar;
        private void btnSatişYap_Click(object sender, EventArgs e)
        {
            
            kur = Convert.ToDouble(textKur.Text);
            miktar = Convert.ToDouble(textMik.Text);
            tutar = miktar * kur;
            textTutar.Text = tutar.ToString();

        }

        private void textKur_TextChanged(object sender, EventArgs e)
        {
            textKur.Text = textKur.Text.Replace(".",",");
           
        }

        private void textkur2_TextChanged(object sender, EventArgs e)
        {
            textkur2.Text = textkur2.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textKur.Text == lblDaliş.Text || textKur.Text == lblDsatiş.Text)
            {
                lbldolarmik.Text += textMik.Text;
                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_DövizTableAdapter.FillBy(this.dbDövizDataSet.Tbl_Döviz);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public double kur2, mik, tutar2;
        private void btnİşlem2_Click(object sender, EventArgs e)
        {
            kur2 = Convert.ToDouble(textkur2.Text);
            mik = Convert.ToInt32(textmik2.Text);
            tutar2 = Convert.ToInt32(mik / kur2);
            texttutar2.Text = tutar2.ToString();
            
            textkalan2.Text = Convert.ToInt32(mik % kur2).ToString();
        }

       
    }
}
