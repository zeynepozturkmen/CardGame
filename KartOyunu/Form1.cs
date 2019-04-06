using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        int sayac = 0;
        int saniye = 0;

        void sifirla()
        {


            pictureBox1_1.Visible = false;
            pictureBox2_2.Visible = false;
            pictureBox3_3.Visible = false;
            pictureBox4_4.Visible = false;
            pictureBox5_5.Visible = false;
            pictureBox6_6.Visible = false;
            pictureBox7_7.Visible = false;
            pictureBox8_8.Visible = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //int kartSayisi = 10;



            Random rnd = new Random();
            //int x = rnd.Next(10, 100);

            //PictureBox[] kartlar = new PictureBox[1];
            //kartlar[1].Location = new Point(10 + x, 20);
            //kartlar[1].ImageLocation=Image.FromFile("")
            sifirla();
         
            int sayi = rnd.Next(1, 8);

            label2.Text = sayac.ToString();

            if (saniye != 60)
            {




                switch (sayi)
                {


                    case 1:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox1.Visible = false;
                        pictureBox1_1.Visible = true;
                        break;

                    case 2:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox2.Visible = false;
                        pictureBox2_2.Visible = true;
                        break;

                    case 3:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox3.Visible = false;
                        pictureBox3_3.Visible = true;
                        break;

                    case 4:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox4.Visible = false;
                        pictureBox4_4.Visible = true;
                        break;

                    case 5:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox5.Visible = false;
                        pictureBox5_5.Visible = true;
                        break;
                    case 6:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox6.Visible = false;
                        pictureBox6_6.Visible = true;
                        break;

                    case 7:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox7.Visible = false;
                        pictureBox7_7.Visible = true;
                        break;

                    case 8:
                        saniye++;
                        label4.Text = saniye.ToString();
                        pictureBox8.Visible = false;
                        pictureBox8_8.Visible = true;
                        break;

                }
                }
                else{
                timer1.Stop();
                   
                 MessageBox.Show("Oyununuz bitti.Skorunuz: " + sayac);
                    
                

                }
            }


        
           



    private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        


            pictureBox1_1.Visible = false;
                pictureBox2_2.Visible = false;
                pictureBox3_3.Visible = false;
                pictureBox4_4.Visible = false;
                pictureBox5_5.Visible = false;
                pictureBox6_6.Visible = false;
                pictureBox7_7.Visible = false;
                pictureBox8_8.Visible = false;

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
            

        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        
        }

        private void pictureBox2_2_Click_1(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
          
        
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
          
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
         
        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
         
        }

        private void pictureBox6_6_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();

        }

        private void pictureBox7_7_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        
        }

        private void pictureBox8_8_Click(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }
        
    }
    }
