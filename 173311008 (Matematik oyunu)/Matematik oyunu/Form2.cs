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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        int r_sık;

        double sonuc;
        int yanlıssoru = 0;
        int dogrusoru = 0;
        



        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonSonrakiSoru.Enabled = true;


            if (r_sık == 4)// yani doğru secenek d ise
            {
                label15.Text = "Cevap D";

                buttonA.BackColor = Color.Red;
                buttonB.BackColor = Color.Red;
                buttonC.BackColor = Color.Red;
                buttonD.BackColor = Color.Blue;

                dogrusoru++;
                labelDogruSoru.Text = dogrusoru.ToString();

                //-----------sonuc






               // buttonD.Text = sonuc.ToString();


                buttonpasiflestirme();

            }
            else //  doğru secenek d değil ise
            {
                buttonD.BackColor = Color.Red;

                yanlıssoru++;
                labelYanlısSoru.Text = yanlıssoru.ToString();
                dogrusoru--;
                labelDogruSoru.Text = dogrusoru.ToString();




                if (r_sık == 1)
                {
                    buttonA.BackColor = Color.Blue;
                    label15.Text = "Cevap A";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                else if (r_sık == 2)
                {
                    buttonB.BackColor = Color.Blue;
                    label15.Text = "Cevap B";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                else if (r_sık == 3)
                {
                    buttonC.BackColor = Color.Blue;
                    label15.Text = "Cevap C";



                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                buttonpasiflestirme();
            }




        }



        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonSonrakiSoru.Enabled = true;

            if (r_sık == 3)// yani doğru secenek c ise
            {
                label15.Text = "Cevap C";
                buttonA.BackColor = Color.Red;
                buttonB.BackColor = Color.Red;
                buttonC.BackColor = Color.Blue;
                buttonD.BackColor = Color.Red;
                //---------------- 


                dogrusoru++;
                labelDogruSoru.Text = dogrusoru.ToString();

                buttonpasiflestirme();

            }
            else //  doğru secenek c değil ise
            {
                buttonC.BackColor = Color.Red;

                yanlıssoru++;
                labelYanlısSoru.Text = yanlıssoru.ToString();
                dogrusoru--;
                labelDogruSoru.Text = dogrusoru.ToString();



                if (r_sık == 1)
                {
                    buttonA.BackColor = Color.Blue;
                    label15.Text = "Cevap A";

                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();


                }
                else if (r_sık == 2)
                {
                    buttonB.BackColor = Color.Blue;
                    label15.Text = "Cevap B";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                else if (r_sık == 4)
                {
                    buttonD.BackColor = Color.Blue;
                    label15.Text = "Cevap D";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                buttonpasiflestirme();
            }
        }



        private void buttonB_Click(object sender, EventArgs e)
        {

            buttonSonrakiSoru.Enabled = true;


            if (r_sık == 2)// yani doğru secenek b ise
            {
                label15.Text = "Cevap B";
                buttonA.BackColor = Color.Red;
                buttonB.BackColor = Color.Blue;
                buttonC.BackColor = Color.Red;
                buttonD.BackColor = Color.Red;

                dogrusoru++;
                labelDogruSoru.Text = dogrusoru.ToString();

                buttonpasiflestirme();

            }
            else //  doğru secenek b değil ise
            {

                buttonB.BackColor = Color.Red;


                yanlıssoru++;
                labelYanlısSoru.Text = yanlıssoru.ToString();
                dogrusoru--;
                labelDogruSoru.Text = dogrusoru.ToString();





                if (r_sık == 1)
                {
                    buttonA.BackColor = Color.Blue;
                    label15.Text = "Cevap A";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                else if (r_sık == 3)
                {
                    buttonC.BackColor = Color.Blue;
                    label15.Text = "Cevap C";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }
                else if (r_sık == 4)
                {
                    buttonD.BackColor = Color.Blue;
                    label15.Text = "Cevap D";


                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                }

                buttonpasiflestirme();








            }

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonSonrakiSoru.Enabled = true;
            


            if (r_sık == 1)// yani doğru secenek a ise
            {
                label15.Text = "Cevap A";

                buttonA.BackColor = Color.Blue;
                buttonB.BackColor = Color.Red;
                buttonC.BackColor = Color.Red;
                buttonD.BackColor = Color.Red;


                dogrusoru++;
                labelDogruSoru.Text = dogrusoru.ToString();


                buttonpasiflestirme();

            }
            else //  doğru secenek a değil ise
            {
                buttonA.BackColor = Color.Red;


                yanlıssoru++;
                labelYanlısSoru.Text = yanlıssoru.ToString();
                dogrusoru--;
                labelDogruSoru.Text = dogrusoru.ToString();

                if (r_sık == 2)
                {
                    buttonB.BackColor = Color.Blue;
                    label15.Text = "Cevap B";

                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();



                }
                else if (r_sık == 3)
                {
                    buttonC.BackColor = Color.Blue;
                    label15.Text = "Cevap C";

                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();

                    
                }
                else if (r_sık == 4)
                {
                    buttonC.BackColor = Color.Blue;
                    label15.Text = "Cevap D";

                    dogrusoru++;
                    labelDogruSoru.Text = dogrusoru.ToString();


                }
                buttonpasiflestirme();

                

            }


        }
        public void buttonAktiflestirme()
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

        }


        public void buttonpasiflestirme()
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }


        Seviye s1 = new Seviye();

        Random ras = new Random();

        


        private void Form2_Load(object sender, EventArgs e)
        {


            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;


            buttonSonrakiSoru.Enabled = false;


            r_sık = ras.Next(1, 4);


            //sonuc değişkeni globaldir yukarıya attım

            sonuc = s1.Cevap(1, 1);

            label1.Text = s1.Sayi1.ToString();
            label2.Text = s1.Sayi2.ToString();


           

            SıkıSayılarlaDoldur();










        }

        Random rn;


        public void SıkıSayılarlaDoldur()
        {

            rn = new Random();

            if (r_sık == 1)
            {
                buttonA.Text = sonuc.ToString();
                buttonB.Text = rn.Next(0, 20).ToString();
                buttonC.Text = rn.Next(0, 20).ToString();
                buttonD.Text = rn.Next(0, 20).ToString();

            }
            else if (r_sık == 2)
            {
                buttonA.Text = rn.Next(0, 20).ToString();
                buttonB.Text = sonuc.ToString();
                buttonC.Text = rn.Next(0, 20).ToString();
                buttonD.Text = rn.Next(0, 20).ToString();


            }

            else if (r_sık == 3)
            {
                buttonA.Text = rn.Next(0, 20).ToString();
                buttonB.Text = rn.Next(0, 20).ToString();
                buttonC.Text = sonuc.ToString();
                buttonD.Text = rn.Next(0, 20).ToString();


            }
            else if (r_sık == 4)
            {
                buttonA.Text = rn.Next(0, 20).ToString();
                buttonB.Text = rn.Next(0, 20).ToString();
                buttonC.Text = rn.Next(0, 20).ToString();
                buttonD.Text = sonuc.ToString();


            }





        }









        public int level=1;
        string[] metin;
        private void buttonSonrakiSoru_Click(object sender, EventArgs e)
        {
             buttonSonrakiSoru.Enabled = false;

            r_sık = ras.Next(1, 4);

            label15.Text = "";
            

            int sayi = Convert.ToInt32(labelSoruSayisi.Text);
            sayi++;
            labelSoruSayisi.Text = Convert.ToString(sayi);


          

            //---------------- seviye belirleme--------------------------------------------------------------------


            if (sayi == 21 && level==1)
            {
                MessageBox.Show("Seviye 1 bitti");
               
                

               
                sayi = 1;
                labelSoruSayisi.Text = "1";

                if (dogrusoru >= 11)
                {
                    MessageBox.Show("Seviye 2 ye hoşgeldiniz");
                    level++;
                   
                    labelLevelSayısı.Text = Convert.ToString(level);

                    dogrusoru = 0;
                    yanlıssoru = 0;

                }
                else
                {
                    MessageBox.Show("Doğru sayınız 11 sayısını geçmediği için bölümü geçemediniz lütfen tekrar deneyiniz");
                    labelDogruSoru.Text = "0";
                    labelYanlısSoru.Text = "0";
                    dogrusoru = 0;
                    yanlıssoru = 0;

                    
                }





                

            }
           else if (sayi == 21 && level == 2)
            {
                MessageBox.Show("Seviye 2 bitti");

                
               
                sayi = 1;
                

                labelSoruSayisi.Text = "1";


                
                if (dogrusoru >= 11)
                {
                    MessageBox.Show("Seviye 3 e hoşgeldiniz");
                    level++;

                    labelLevelSayısı.Text = Convert.ToString(level);

                    dogrusoru = 0;
                    yanlıssoru = 0;



                }
                else
                {
                    MessageBox.Show("Doğru sayınız 11 sayısını geçmediği için bölümü geçemediniz lütfen tekrar deneyiniz");
                    labelDogruSoru.Text = "0";
                    labelYanlısSoru.Text = "0";
                    dogrusoru = 0;
                    yanlıssoru = 0;


                }





            }
            else if (sayi == 21 && level == 3)
            {
                MessageBox.Show("Seviye 3 bitti");

                sayi = 1;


                labelSoruSayisi.Text = "1";



                if (dogrusoru >= 11)
                {
                    MessageBox.Show("Seviye 4 e hoşgeldiniz");
                    level++;

                    labelLevelSayısı.Text = Convert.ToString(level);


                    dogrusoru = 0;
                    yanlıssoru = 0;

                }
                else
                {
                    MessageBox.Show("Doğru sayınız 11 sayısını geçmediği için bölümü geçemediniz lütfen tekrar deneyiniz");
                    labelDogruSoru.Text = "0";
                    labelYanlısSoru.Text = "0";
                    dogrusoru = 0;
                    yanlıssoru = 0;


                }
            }
            else if (sayi == 21 && level == 4)
            {
                MessageBox.Show("Seviye 4 bitti");

                sayi = 1;


                labelSoruSayisi.Text = "1";



                if (dogrusoru >= 11)
                {
                    MessageBox.Show("Seviye 5 e hoşgeldiniz");
                    level++;

                    labelLevelSayısı.Text = Convert.ToString(level);

                    dogrusoru = 0;
                    yanlıssoru = 0;


                }
                else
                {
                    MessageBox.Show("Doğru sayınız 11 sayısını geçmediği için bölümü geçemediniz lütfen tekrar deneyiniz");
                    labelDogruSoru.Text = "0";
                    labelYanlısSoru.Text = "0";
                    dogrusoru = 0;
                    yanlıssoru = 0;


                }
            }

//--------------------sorulara ve levele göre işlemler --------------------------------------------------------
            sonuc = s1.Cevap(sayi,level);
            
            label1.Text = s1.Sayi1.ToString();
          label2.Text = s1.Sayi2.ToString();





 //----------------------------------------------------------------------------------------------
            //------------------tekrar şık oluşturma ------------------------------


            if (r_sık == 1)
            {
                buttonA.Text = sonuc.ToString();
                //aynı seçenekler gelmemesin diye yazdığım döngü
                while (sonuc== Convert.ToInt32(buttonB.Text) || sonuc == Convert.ToInt32(buttonC.Text) || sonuc == Convert.ToInt32(buttonD.Text))
                {
                    buttonB.Text = rn.Next(0, 20).ToString();
                    buttonC.Text = rn.Next(0, 20).ToString();
                    buttonD.Text = rn.Next(0, 20).ToString();


                }
                



            }
            else if (r_sık == 2)
            {
                   


                buttonB.Text = sonuc.ToString();


                
                
                while (sonuc == Convert.ToInt32(buttonA.Text) || sonuc == Convert.ToInt32(buttonC.Text) || sonuc == Convert.ToInt32(buttonD.Text))
                {
                    buttonA.Text = rn.Next(0, 20).ToString();
                    buttonC.Text = rn.Next(0, 20).ToString();
                    buttonD.Text = rn.Next(0, 20).ToString();


                }




            }

            else if (r_sık == 3)
            {
                 
                buttonC.Text = sonuc.ToString();
                  

                while (sonuc == Convert.ToInt32(buttonA.Text) || sonuc == Convert.ToInt32(buttonB.Text) || sonuc == Convert.ToInt32(buttonD.Text))
                {
                    buttonA.Text = rn.Next(0, 20).ToString();
                    buttonB.Text = rn.Next(0, 20).ToString();
                    buttonD.Text = rn.Next(0, 20).ToString();


                }






            }
            else if (r_sık == 4)
            {
                 
                buttonD.Text = sonuc.ToString();

                while (sonuc == Convert.ToInt32(buttonA.Text) || sonuc == Convert.ToInt32(buttonB.Text) || sonuc == Convert.ToInt32(buttonC.Text))
                {
                    buttonA.Text = rn.Next(0, 20).ToString();
                    buttonB.Text = rn.Next(0, 20).ToString();
                    buttonC.Text = rn.Next(0, 20).ToString();


                }






            }


//------------------------------------------------------------

            
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            

            buttonAktiflestirme();


            if (sayi > 0 && sayi < 5)
            {
                labelİslem.Text = "Toplama";
                labelİsaret.Text = "+";

            }

           else if(sayi>5 && sayi < 10)
            {
                labelİslem.Text = "Çıkartma";
                labelİsaret.Text = "-";


            }
            else if (sayi>10 && sayi<15)
            {

                labelİslem.Text = "Çarpma";
                labelİsaret.Text = "*";

            }
            else if (sayi > 15 && sayi < 20)
            {

                labelİslem.Text = "Bölme";
                labelİsaret.Text = "/";

            }




            // ------  dogru soruları ve leveli metin belgesine yazdırma -------------------------------------


            metin = System.IO.File.ReadAllLines(Application.StartupPath + "\\Level.txt");

            metin[0] = Convert.ToString(level);
            metin[1] = Convert.ToString(dogrusoru);

            System.IO.File.WriteAllLines(Application.StartupPath + "\\Level.txt", metin);

            metin[0] = Convert.ToString(level);
            metin[1] = Convert.ToString(dogrusoru);







            //---------------------------------------------------------------------------------------------------------------------------









        }

        int pass = 0;

        private void button2_Click(object sender, EventArgs e)
        {

            buttonSonrakiSoru.Enabled = true;


            pass++;
            if (pass == 2)
            {
                yanlıssoru++;
                pass = 0;
                
            }
            labelYanlısSoru.Text = yanlıssoru.ToString();

            buttonSonrakiSoru.PerformClick();


        }
    }
}
