using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Passaparola : Form
    {
        public Passaparola()
        {
            InitializeComponent();
        }
        int soruno = 0, Dogru = 0, Yanlis = 0;

        private void Passaparola_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kıyısındaki bölgesi?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çicek festivali?";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç,havuç gibi sebzeler ile yapılan yemek?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın Sultanı?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Eğe bölgesinin en çok ağacı bulunan yağıda yapılan bir kahvaltı besini?";
                button1.BackColor = Color.Yellow;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text=="akdeniz")
                        {
                            button23.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 2:
                        if (textBox1.Text=="bursa")
                        {
                            button2.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 3:
                        if (textBox1.Text=="cuma")
                        {
                            button3.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 4:
                        if (textBox1.Text=="diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 13:
                        if (textBox1.Text == "lale festivali")
                        {
                            button24.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button13.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button20.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 17:
                        if (textBox1.Text == "pırasa yemeği")
                        {
                            button19.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button17.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button16.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button15.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button21.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button1.BackColor = Color.Green;
                            Dogru++;
                            label2.Text = Dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            Yanlis++;
                            label4.Text = Yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                }
            }
        }
    }
}
