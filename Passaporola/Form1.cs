using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaporola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void temizle()
        {
            textBox1.Text = "";
        }
        int soruno =0, dogru = 0, yanliş = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text=="akdeniz")
                        {
                            BtnA.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            BtnB.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red; yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            BtnC.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "denizli")
                        {
                            BtnD.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red; yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            BtnE.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fetha")
                        {
                            BtnF.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            BtnG.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            BtnH.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 9:
                        if (textBox1.Text =="ısparta")
                        {
                            BtnI.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            Btnİ.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            Btnİ.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            BtnJ.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            BtnK.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            BtnL.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mayıs")
                        {
                            BtnM.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            BtnN.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            BtnO.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            BtnP.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            BtnR.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            BtnS.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tyt")
                        {
                            BtnT.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Umut")
                        {
                            BtnU.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            BtnV.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yale")
                        {
                            BtnY.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zoom")
                        {
                            BtnZ.BackColor = Color.SeaGreen;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            yanliş++;
                            label3.Text = yanliş.ToString();
                            temizle();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno ++;
            this.Text= soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesindeki?";
                BtnA.BackColor=Color.Yellow;  
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle Ünlü Marmara İlimiz?";
                BtnB.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslüman erkeklerin camiye gidip cemaatle kıldığı namazın günü?";
                BtnC.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla meşhur ilimiz?";
                BtnD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesini zıt anlamlası?";
                BtnE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirleri yazılı hali?";
                BtnF.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                BtnG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin Kötü karne bakıştığı nesne?";
                BtnH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyla ünlü ilimiz?";
                BtnI.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersini diğer ismi?";
                Btnİ.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                BtnJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                BtnK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlemem çiçek festivalli?";
                BtnL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın Üçüncü Ayı?";
                BtnM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                BtnN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                BtnO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların şevmediği pirnç,havuç gibi sebzeler ile yapilan yemek?";
                BtnP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın Sultanı?";
                BtnR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılanın Türkçesi nedir?";
                BtnS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Yks'nın İlk Oturumu?";
                BtnT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                BtnU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkenin en büyük gölü nerede bulunmaktadır?";
                BtnV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "ABD'nın New Haven kentinde bulunana ünlü üniversite?";
                BtnY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Pandemiden dolayı Öğrencilerin Derslerini İşlediği Uygulama?";
                BtnZ.BackColor = Color.Yellow;
            }
        }
    }
}
