using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void göster()
        {


            foreach (PictureBox p in panel1.Controls)
            {
                p.Image = imageList1.Images[(int)p.Tag];
            }

        }


        public void gizle()
        {

            foreach (PictureBox p in panel1.Controls)
            {
                p.Image = imageList1.Images[0];
            }


        }
        public void  karistir()
        {

            ArrayList resim = new ArrayList();
            for(int i = 0; i < 20; i++)
            {
                resim.Add((i % 10) + 1);

            }
            Random rn = new Random();
           foreach(PictureBox p in panel1.Controls)
            {
                int rastgele = rn.Next(resim.Count);
                p.Tag = resim[rastgele];
                resim.RemoveAt(rastgele);



            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

            gizle();
            karistir();


            label2.Text = "Sıra Oyuncu 1 de ";


        }
        PictureBox resim_ikinci;
        int tıklanan;
      bool oyuncuSıra = true;
        int oyuncu1=0, oyuncu2=0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            PictureBox resim_ilk = sender as PictureBox;
            resim_ilk.Image = imageList1.Images[(int)resim_ilk.Tag];
            panel1.Refresh();

            

            if (tıklanan ==0)
            {
                
                resim_ikinci = resim_ilk;
                tıklanan++;
                Thread.Sleep(1000);
                return;
               

            }
            else if (tıklanan == 1 )
            {
              

                if (oyuncuSıra == true)
                {
                    

                    if (resim_ikinci.Tag.ToString() == resim_ilk.Tag.ToString())
                    {
                        oyuncu1++;
                        label5.Text = ""+oyuncu1;
                    }
                    label2.Text = "Sıra Oyuncu 2 de ";
                    

                    oyuncuSıra = false;
                }
                else 
                {
                   
                    oyuncuSıra = true;

                    if (resim_ikinci.Tag.ToString() == resim_ilk.Tag.ToString())
                    {
                        oyuncu2++;
                        label6.Text = "" + oyuncu2;
                    }

                    label2.Text = "Sıra Oyuncu 1 de ";
                    
                }
                MessageBox.Show(label2.Text);


                Thread.Sleep(1500);
                if (resim_ikinci.Tag.ToString() == resim_ilk.Tag.ToString())
                {

                    if (resim_ilk == resim_ikinci)
                    {
                        return;

                    }
                    resim_ilk.Hide();
                    resim_ikinci.Hide();

                }
                else 
                {
                    gizle();
                }



                tıklanan = 0;
            }





        }
        int zaman = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            zaman--;
            if (zaman >= 0)
            {
                göster();

                label1.Text = zaman.ToString();
                
            }
            else
            {
                gizle();
            }
        }
    }
}
