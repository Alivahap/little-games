using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Show();
            f1.Hide();

        }


        string[] metin;


        int level;


       // string[] yıldız;

        public void yıldızbelirle()
        {
            int dogrusoru;
            metin = System.IO.File.ReadAllLines(Application.StartupPath + "\\Level.txt");

        //    yıldız = System.IO.File.ReadAllLines(Application.StartupPath + "\\yıldızbelirle.txt");

            dogrusoru = Convert.ToInt32(metin[1]);
            //----------------------------------------------level 1 de kaç yıldız yazacağını yazan kod sayısı Burada kaldım 


            if (level == 1)
            {

                if (dogrusoru >= 11 && dogrusoru <= 15)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;


                    //    yıldız[0] = "1";
                    //   System.IO.File.WriteAllLines(Application.StartupPath + "\\yıldızbelirle.txt", yıldız);

                }
                else if (dogrusoru > 15 && dogrusoru <= 18)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;

                    //  yıldız[0] = "2";
                    //  System.IO.File.WriteAllLines(Application.StartupPath + "\\yıldızbelirle.txt", yıldız);


                }
                else if (dogrusoru > 18 && dogrusoru <= 20)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;

                    //   yıldız[0] = "2";
                    // System.IO.File.WriteAllLines(Application.StartupPath + "\\yıldızbelirle.txt", yıldız);


                }



            }
            /*          else if (level == 2)
                      {



                          if (dogrusoru >= 11 && dogrusoru <= 15)
                          {
                              pictureBox4.Visible = true;
                              pictureBox5.Visible = false;
                              pictureBox6.Visible = false;

                              yıldız[1] = "1";


                          }
                          else if (dogrusoru > 15 && dogrusoru <= 18)
                          {
                              pictureBox4.Visible = true;
                              pictureBox5.Visible = true;
                              pictureBox6.Visible = false;

                              yıldız[1] = "2";


                          }
                          else if (dogrusoru > 18 && dogrusoru <= 20)
                          {
                              yıldız[1] = "3";


                              pictureBox4.Visible = true;
                              pictureBox5.Visible = true;
                              pictureBox6.Visible = true;


                          }
                          System.IO.File.WriteAllLines(Application.StartupPath + "\\yıldızbelirle.txt", yıldız);

                      }

              */

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

            

            //metin[0] level bilgisi, metin[1] dogru soru sayısı


            metin = System.IO.File.ReadAllLines(Application.StartupPath + "\\Level.txt");
            level = Convert.ToInt32(metin[0]);
            

            seviyebelirle();
            yıldızbelirle();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;





            //       pictureBox1.Visible = true;
            //     pictureBox2.Visible = true;
            //   pictureBox3.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            yıldızbelirle();
            seviyebelirle();




        }
       


        public void seviyebelirle()
        {
            
            if (level == 1)
            {


                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;



                yıldızbelirle();

            }


            else if (level == 2)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;


                yıldızbelirle();

            }
            else if (level == 3)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;

                yıldızbelirle();
            }
            else if (level == 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;

                yıldızbelirle();
            }
            else if (level == 5)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;


                yıldızbelirle();

            }



        }
        

        public void levelac()
        {

            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Show();

            f2.buttonSonrakiSoru.Enabled = true;
            f1.Hide();

        }
      
         

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();

            f2.Show();

            f2.level = 2;
            f2.labelLevelSayısı.Text =""+2;

            f1.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Show();

            f2.level = 3;
            f2.labelLevelSayısı.Text = "" + 3;

            f1.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f2.Show();

            f2.level = 4;
            f2.labelLevelSayısı.Text = "" + 4;

            f1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();

            f2.Show();

            f2.level = 5;
            f2.labelLevelSayısı.Text = "" + 5;

            f1.Hide();
        }
    }
}
