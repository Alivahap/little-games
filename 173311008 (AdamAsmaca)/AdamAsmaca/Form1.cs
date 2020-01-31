using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kelime="";
        int k_uzunlugu;
        string[] harf;
        int bilinenharfler;
        string Text_harfi;
        int kalanhak;
        int puan = 0;
        string[] Toplampuan;
        

        private void Form1_Load(object sender, EventArgs e)
        {

             Dosyaoku();
            string[] puanoku;
            
         puanoku=File.ReadAllLines(Application.StartupPath + "\\puan.txt");
            label7.Text = puanoku[0];

            k_uzunlugu = kelime.Length;
            kalanhak = k_uzunlugu + 2;
            harf = new string[k_uzunlugu];
            label3.Text=Convert.ToString(k_uzunlugu);

            label_kelimeaktarımı();
            harflereayır();
           
          


        }

        public  void Dosyaoku()
        {
            
            string[] metin;
            Random r = new Random();
          

            metin =File.ReadAllLines(Application.StartupPath + "\\metin.txt ");
             kelime=metin [r.Next(0, metin.Length)];

            label6.Text = kelime;

           

        }
















        public void label_kelimeaktarımı()
        {
            label_kelime.Text="";
            for(int i = 0; i < kelime.Length; i++)
            {
                label_kelime.Text += "_";

            }

        }
        public void harflereayır()
        {
            for(int i = 0; i < k_uzunlugu; i++)
            {
                harf[i] = kelime.Substring(i, 1);
               
            }


        }






        

        private void button1_Click(object sender, EventArgs e)
        {


            //Yanlısharf_label.Text = "";

            if (textBox1.Text =="")
            {
                MessageBox.Show("Lütfen Bir Harf Giriniz");

            }
            else 
            {
                

                 Text_harfi =textBox1.Text;

                int kontrol = 0;

                
                  



                for (int i = 0; i < k_uzunlugu; i++)
                {
                    string label_harfleri = label_kelime.Text;

                   

                    if (Text_harfi == harf[i])
                    {

                      label_harfleri = label_harfleri.Remove(i, 1);
                     label_kelime.Text=label_harfleri.Insert(i,Text_harfi);


                       bilinenharfler++;


                        puanislemleri();
                        

                        kontrol = 1;
                        
                    }

//                    if (textBox1.Text != harf[i])
 //                   {
 //
     //                   label6.Text += textBox1.Text + ",";
   //                     kontrol = 0;
       //                 return;
                        
         //           }





                }
                if (kontrol == 0)
                {
                    kalanhak--;
                    MessageBox.Show(kalanhak.ToString());
                    

                }
                 


            }
           
            
            // kelime sayısını kontrol ederek oyunu bitirme kodları
            if (bilinenharfler == k_uzunlugu)
            {
                MessageBox.Show("Oyun Bitti, KAZANDINIZ!");
                button1.Enabled = false;
                
            }
            else if(kalanhak == 0)
            {
                MessageBox.Show("Oyun Bitti, KAYBETİNİZ!");

                
                button1.Enabled = false;
            }


        }

        
        public void puanislemleri()
        {


            puan = +10;

            Toplampuan = File.ReadAllLines(Application.StartupPath + "\\puan.txt");

            puan += Convert.ToInt32(Toplampuan[0]);

            Toplampuan[0] = puan.ToString();

            

            File.WriteAllLines(Application.StartupPath + "\\puan.txt", Toplampuan);

            label7.Text = puan.ToString();

        }
      



    }
}
