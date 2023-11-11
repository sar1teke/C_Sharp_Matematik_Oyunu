﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Oyunu
{
    public partial class Seviye3 : Form
    {
        public Seviye3()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru, yanlis, zaman=60;

        String a;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            zaman--;
            Convert.ToInt32(label11.Text);
            label11.Text = zaman.ToString();

            if (zaman == 0)
            {
                yanlis++;
                label5.Text = yanlis.ToString();
                label10.Text = "Süre Doldu!!!";
                button5.Enabled = true;

                timer1.Enabled = false;

                label9.Visible = true;
                label12.Visible = true;
                label13.Visible = false;
                

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            label8.Text = button1.Text;

            if (label8.Text == label9.Text)
            {
                label10.Text = "Doğru";
                dogru++;

                label4.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();

                label10.Text = "Yanlış";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label8.Text = button2.Text;

            if (label8.Text == label9.Text)
            {
                label10.Text = "Doğru";
                dogru++;

                label4.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();

                label10.Text = "Yanlış";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label8.Text = button4.Text;

            if (label8.Text == label9.Text)
            {
                label10.Text = "Doğru";
                dogru++;

                label4.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();

                label10.Text = "Yanlış";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label8.Text = button3.Text;

            if (label8.Text == label9.Text)
            {
                label10.Text = "Doğru";
                dogru++;

                label4.Text = dogru.ToString();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();

                label10.Text = "Yanlış";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                button5.Enabled = true;
                timer1.Enabled = false;
            }
        }

        int passayisi = 0;

        private void button8_Click_1(object sender, EventArgs e)
        {
            passayisi++;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (soruno < 22)
            {
                timer1.Enabled = false;
                button5.Enabled = true;
                richTextBox1.Text = "Soru pas geçilmiştir devam etmek için lütfen ileri tuşuna basınız.";
            }
            if (passayisi == 2)
            {
                MessageBox.Show("2 Pas yaptınız hakkınız dolmuştur.");
                yanlis = +1;
            }

            else if (passayisi == 3)
            {
                yanlis++;
                label5.Text = yanlis.ToString();
                label10.Text = "Yanlış";

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

            else
            {
                MessageBox.Show("Sorular Bitmiştir");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button5.Text = "İLERİ";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label10.Text = "";
            label12.Visible = false;
            label9.Visible = false;
            label13.Visible = true;
            label8.Visible = false;

            soruno++;
            label7.Text = soruno.ToString();

            zaman = 60;

            if (soruno == 1)
            {
                button5.Enabled = false;
                richTextBox1.Text = "145-45 = ? " + "  35+658 = ?" + "  897-97 = ? " + "  145+55 = ? " + "  45/9 = ? ";

                button1.Text = "25,50,42,10,13";
                button2.Text = "10,14,10,11,13";
                button3.Text = "100,693,800,200,5";
                button4.Text = "15,17,45,36,14";

                label9.Text = "100,693,800,200,5";

                button5.Text = "Seviye 3 İkinci Kısım";
            }

            if (soruno == 2)
            {
                button5.Enabled = false;
                richTextBox1.Text = "145-45 = ? " + "  35+658 = ?" + "  897-97 = ? " + "  145+55 = ? " + "  45/9 = ? ";

                button1.Text = "25,50,42,10,13";
                button2.Text = "10,14,10,11,13";
                button3.Text = "100,693,800,200,5";
                button4.Text = "15,17,45,36,14";

                label9.Text = "100,693,800,200,5";

                button5.Text = "Seviye 3 Üçüncü Kısım";
            }

            if (soruno == 3)
            {
                button5.Enabled = false;
                richTextBox1.Text = "145-45 = ? " + "  35+658 = ?" + "  897-97 = ? " + "  145+55 = ? " + "  45/9 = ? ";

                button1.Text = "25,50,42,10,13";
                button2.Text = "10,14,10,11,13";
                button3.Text = "100,693,800,200,5";
                button4.Text = "15,17,45,36,14";

                label9.Text = "100,693,800,200,5";

                button5.Text = "Seviye 3 Dördüncü Kısım";
            }

            if (soruno == 4)
            {
                button5.Enabled = false;
                richTextBox1.Text = "145-45 = ? " + "  35+658 = ?" + "  897-97 = ? " + "  145+55 = ? " + "  45/9 = ? ";

                button1.Text = "25,50,42,10,13";
                button2.Text = "10,14,10,11,13";
                button3.Text = "100,693,800,200,5";
                button4.Text = "15,17,45,36,14";

                label9.Text = "100,693,800,200,5";

                button5.Text = "Seviye 3 Beşinci Kısım";
            }

            if (soruno == 5)
            {
                button5.Enabled = false;
                richTextBox1.Text = "145-45 = ? " + "  35+658 = ?" + "  897-97 = ? " + "  145+55 = ? " + "  45/9 = ? ";

                button1.Text = "25,50,42,10,13";
                button2.Text = "10,14,10,11,13";
                button3.Text = "100,693,800,200,5";
                button4.Text = "15,17,45,36,14";

                label9.Text = "100,693,800,200,5";

                button5.Text = "Seviye Sonu";
            }

            if (soruno == 6)
            {
                button5.Enabled = false;
                button6.Visible = true;
                button7.Visible = true;
                if (1 <= dogru && dogru <= 2)
                {
                    a = "  Sonraki Seviyeye Geçemeye Hak Kazandınız *  ";
                }
                if (3 <= dogru && dogru <= 4)
                {
                    a = "  Orta Seviyede Başarı Elde Ettiniz **  ";
                }
                if (4 <= dogru && dogru <= 5)
                {
                    a = "  Bravo Üstün Başarı Elde Ettiniz ***  ";
                }
                else
                {
                    a = "  Maalesef , Başarısız Oldunuz";
                }

                DialogResult sonuc = MessageBox.Show("Doğru:   " + dogru + a + "\n" + "Yanlış:   " + yanlis + "\n" + " Devam Etmek İstiyormusunuz ", "SKOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (soruno == 6)
            {
                Seviye4 frm4 = new Seviye4();

                this.Hide();
                frm4.ShowDialog();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button5.Text = "BAŞLAT";
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }
    }
}