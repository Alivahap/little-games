using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int enkck_deger, enbyk_deger;

     

        private void Form1_Load(object sender, EventArgs e)
        {
            gizle();

            listBox1.Visible = false;
            label0.Visible = false;

            timer1.Interval = 1000;

            comboBoxHakSayısı.Items.Add("5");
            comboBoxHakSayısı.Items.Add("10");
            comboBoxHakSayısı.Items.Add("15");
            comboBoxHakSayısı.Items.Add("20");



        }

        public void gizle()
        {

            Sayıuret s = new Sayıuret();

            s.labelgizle(groupBox2);
            s.Buttongizle(groupBox1);
          

            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";

        }

       


        int sayi_uret;
        char[] Rakamlar;
        int sayı_uzunluk;
        string sayi_tekrarlı;

        int zamanlayici;

        private void buttonRastgele_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            try
            {
                hak = Convert.ToInt32(comboBoxHakSayısı.Text);
                labelHak.Text = hak.ToString();
            }
            catch
            {
                MessageBox.Show("lütfen hak sayısını giriniz");
            }
       

            if (comboBoxHakSayısı.Items[0].ToString()==comboBoxHakSayısı.Text )
            {
                zamanlayici = 0;
                zamanlayici = 60;
                timer1.Start();
            }
           else if (comboBoxHakSayısı.Items[1].ToString() == comboBoxHakSayısı.Text)
            {
                zamanlayici = 0;
                zamanlayici = 90;
                timer1.Start();
            }
            else if (comboBoxHakSayısı.Items[2].ToString() == comboBoxHakSayısı.Text)
            {
                zamanlayici = 0;
                zamanlayici = 120;
                timer1.Start();
            }
            else if (comboBoxHakSayısı.Items[3].ToString() == comboBoxHakSayısı.Text)
            {
                zamanlayici = 0;
                zamanlayici = 150;
                timer1.Start();
            }



            listBox1.Items.Clear();
            try
            {

                enbyk_deger = Convert.ToInt32(textBox0.Text);
                enbyk_deger = Convert.ToInt32(Math.Pow(10, enbyk_deger));
                enbyk_deger = enbyk_deger - 1;

                enkck_deger = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(textBox0.Text) - 1));


            }
            catch
            {
                MessageBox.Show("Lütfen Bir Sayı Giriniz ve 10 sayısını geçmesin bu sayı ");
            }




            

            Random rastgele = new Random();






            Rakamlar =new char[15];
            

            if (radioButton1.Checked == true)
            {


                sayi_uret = rastgele.Next(enkck_deger, enbyk_deger);
                label0.Text = sayi_uret.ToString();
                sayı_uzunluk = sayi_uret.ToString().Length;

                Rakamlar = sayi_uret.ToString().ToArray();

                foreach (char eleman in Rakamlar)
                {
                    listBox1.Items.Add(eleman.ToString());
                }
                gizle();

                if (sayı_uzunluk == 1)
                {
                    textBox10.Visible = true;
                    label10.Visible = true;



                }
                else if (sayı_uzunluk == 2)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" 
                            )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" 
                          )
                        {
                            x.Visible = true;
                        }
                    }




                }
                else if (sayı_uzunluk == 3)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            
                            )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" 
                          )
                        {
                            x.Visible = true;
                        }
                    }

                }

                else if (sayı_uzunluk == 4)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" 
                            )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" 
                          )
                        {
                            x.Visible = true;
                        }
                    }


                }
                else if (sayı_uzunluk == 5)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" || x.Name == "textBox6"
                            )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                          )
                        {
                            x.Visible = true;
                        }
                    }


                }
                else if (sayı_uzunluk == 6)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" || x.Name == "textBox6" 
                            || x.Name == "textBox5")
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6" || x.Name == "label5"
                          )
                        {
                            x.Visible = true;
                        }
                    }




                }
                else if (sayı_uzunluk == 7)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5"
                            || x.Name == "textBox4" )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                          || x.Name == "label5" || x.Name == "label4" )
                        {
                            x.Visible = true;
                        }
                    }



                }
                else if (sayı_uzunluk == 8)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5"
                            || x.Name == "textBox4" || x.Name == "textBox3" )
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                          || x.Name == "label5" || x.Name == "label4" || x.Name == "label3" )
                        {
                            x.Visible = true;
                        }
                    }


                }
                else if (sayı_uzunluk == 9)
                {
                    foreach (var x in groupBox1.Controls.OfType<TextBox>())
                    {
                        if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                            || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5"
                            || x.Name == "textBox4" || x.Name == "textBox3" || x.Name == "textBox2")
                        {
                            x.Visible = true;
                        }
                    }

                    foreach (var x in groupBox2.Controls.OfType<Label>())
                    {
                        if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                          || x.Name == "label5" || x.Name == "label4" || x.Name == "label3" || x.Name == "label2")
                        {
                            x.Visible = true;
                        }
                    }

                }








            }
            else if (radioButton2.Checked == true)
            {
       
                
                listBox1.Items.Clear();


                atla:
                
                Random rsg = new Random();
                
                int s1 = rsg.Next(1, 9), s2 = rsg.Next(0, 9), s3 = rsg.Next(0, 9), s4 = rsg.Next(0, 9)
                    , s5 = rsg.Next(0, 9), s6 = rsg.Next(0, 9), s7 = rsg.Next(0, 9), s8 = rsg.Next(0, 9),
                    s9 = rsg.Next(0, 9);

                if (s1 == s2 || s2 == s3 || s3 == s4 || s4 == s5 || s5 == s6 || s6 == s7 || s7 == s8 || s8 == s9
                

                    )
                {
                    goto atla;
                    
                }
                else
                {

                    gizle();

              

                    if (textBox0.Text == "1")
                    {
                        
                        label0.Text = ""+s1;
                        sayi_tekrarlı = label0.Text;

                       // textBox10.Visible = true;
                       // label10.Visible = true;

                    foreach(var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if(x.Name== "textBox10")
                            {
                                x.Visible = true;
                            }
                        }

                     foreach(var x in groupBox2.Controls.OfType<Label>())
                        {
                            if(x.Name== "label10")
                            {
                                x.Visible = true;
                            }
                        }


                    }
                    else if (textBox0.Text == "2")
                    {
                        label0.Text =  s1+""+s2;
                        sayi_tekrarlı = label0.Text;


                       

                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9")
                            {
                                x.Visible = true;
                            }
                        }






                    }
                    else if (textBox0.Text == "3")
                    {
                        label0.Text = s1 + "" + s2+""+s3;
                        sayi_tekrarlı = label0.Text;


                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8")
                            {
                                x.Visible = true;
                            }
                        }
                    }
                    else if (textBox0.Text == "4")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3+""+s4;
                        sayi_tekrarlı = label0.Text;

                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8" || x.Name == "textBox7")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7")
                            {
                                x.Visible = true;
                            }
                        }


                    }
                    else if (textBox0.Text == "5")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3 + "" + s4+""+s5;
                        sayi_tekrarlı = label0.Text;

                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8" || x.Name == "textBox7" || x.Name == "textBox6")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6")
                            {
                                x.Visible = true;
                            }
                        }

                    }
                    else if (textBox0.Text == "6")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3 + "" + s4 + "" + s5+""+s6;
                        sayi_tekrarlı = label0.Text;


                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8" 
                                || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8"
                                || x.Name == "label7" || x.Name == "label6"
                              || x.Name == "label5")
                            {
                                x.Visible = true;
                            }
                        }



                    }
                    else if (textBox0.Text == "7")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3 + "" + s4 + "" + s5+""+s6+""+s7;
                        sayi_tekrarlı = label0.Text;

                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                                || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5" || x.Name == "textBox4")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                              || x.Name == "label5" || x.Name == "label4")
                            {
                                x.Visible = true;
                            }
                        }

                    }
                    else if (textBox0.Text == "8")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3 + "" + s4 + "" + s5 + "" + s6 + "" + s7+""+s8;
                        sayi_tekrarlı = label0.Text;
                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                                || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5" 
                                || x.Name == "textBox4" || x.Name == "textBox3")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                              || x.Name == "label5" || x.Name == "label4" || x.Name == "label3")
                            {
                                x.Visible = true;
                            }
                        }

                    }
                    else if (textBox0.Text == "9")
                    {
                        label0.Text = s1 + "" + s2 + "" + s3 + "" + s4 + "" + s5 + "" + s6 + "" + s7 + "" + s8+""+s9;
                        sayi_tekrarlı = label0.Text;

                        foreach (var x in groupBox1.Controls.OfType<TextBox>())
                        {
                            if (x.Name == "textBox10" || x.Name == "textBox9" || x.Name == "textBox8"
                                || x.Name == "textBox7" || x.Name == "textBox6" || x.Name == "textBox5"
                                || x.Name == "textBox4" || x.Name == "textBox3" || x.Name == "textBox2")
                            {
                                x.Visible = true;
                            }
                        }

                        foreach (var x in groupBox2.Controls.OfType<Label>())
                        {
                            if (x.Name == "label10" || x.Name == "label9" || x.Name == "label8" || x.Name == "label7" || x.Name == "label6"
                              || x.Name == "label5" || x.Name == "label4" || x.Name == "label3" || x.Name == "label2")
                            {
                                x.Visible = true;
                            }
                        }


                    }


                    Rakamlar = sayi_tekrarlı.ToString().ToArray();

                    foreach (char eleman in Rakamlar)
                    {
                        listBox1.Items.Add(eleman.ToString());
                    }

                }
     




            }



            foreach (Label l in groupBox2.Controls)
            {
                l.BackColor = Color.White;
            }











        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zamanlayici--;
            labelGösterge.Text = zamanlayici.ToString();

            if (zamanlayici == 0)
            {
                MessageBox.Show("Oyun Bitti Tekrar deneyiniz");
                timer1.Stop();
            }

        }
        int hak;
        private void button1_Click(object sender, EventArgs e)

        {
            
            hak--;
            labelHak.Text = hak.ToString();
            if (hak == 0)
            {
                MessageBox.Show("Hakkınız Kalmadığı için Oyun bitti ");
                timer1.Stop();
            }
            





            if (textBox0.Text == "1")
            {

                if (textBox10.Text==listBox1.Items[0].ToString())
                {
                    label10.BackColor = Color.Blue;
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();
                    
                }
                else
                {
                    label10.BackColor = Color.Red;
                    
                }



            }
            else if (textBox0.Text == "2")
            {
                if (textBox9.Text == listBox1.Items[0].ToString())
                {
                    label9.BackColor = Color.Blue;

                }
                else
                {
                    label9.BackColor = Color.Red;
                }

                if (textBox10.Text == listBox1.Items[1].ToString())
                {
                    label10.BackColor = Color.Blue;

                }
                else
                {
                    label10.BackColor = Color.Red;
                }
                if(label9.BackColor == Color.Blue && label10.BackColor == Color.Blue)
                {
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();

                }




            }

            else if (textBox0.Text == "3")
            {

                if (textBox8.Text == listBox1.Items[0].ToString())
                {
                    label8.BackColor = Color.Blue;

                }
                else
                {
                    label8.BackColor = Color.Red;
                }

                //------------------------

                if (textBox9.Text == listBox1.Items[1].ToString())
                {
                    label9.BackColor = Color.Blue;

                }
                else
                {
                    label9.BackColor = Color.Red;
                }


                //----------------
                if (textBox10.Text == listBox1.Items[2].ToString())
                {
                    label10.BackColor = Color.Blue;

                }
                else
                {
                    label10.BackColor = Color.Red;
                }

                if (label9.BackColor == Color.Blue && label10.BackColor == Color.Blue && label8.BackColor == Color.Blue)
                {
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();

                }

            }


            else if (textBox0.Text == "4")
            {

                if (textBox7.Text == listBox1.Items[0].ToString())
                {
                    label7.BackColor = Color.Blue;

                }
                else
                {
                    label7.BackColor = Color.Red;
                }

                //------------------------

                if (textBox8.Text == listBox1.Items[1].ToString())
                {
                    label8.BackColor = Color.Blue;

                }
                else
                {
                    label8.BackColor = Color.Red;
                }


                //----------------
                if (textBox9.Text == listBox1.Items[2].ToString())
                {
                    label9.BackColor = Color.Blue;

                }
                else
                {
                    label9.BackColor = Color.Red;
                }
                //-----------
                if (textBox10.Text == listBox1.Items[3].ToString())
                {
                    label10.BackColor = Color.Blue;

                }
                else
                {
                    label10.BackColor = Color.Red;
                }



                //---------------

                if (label9.BackColor == Color.Blue && label10.BackColor == Color.Blue && label8.BackColor == Color.Blue && label7.BackColor == Color.Blue)
                {
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();

                }

            }

            else if (textBox0.Text == "5")
            {

                if (textBox6.Text == listBox1.Items[0].ToString())
                {
                    label6.BackColor = Color.Blue;

                }
                else
                {
                    label6.BackColor = Color.Red;
                }

                //------------------------

                if (textBox7.Text == listBox1.Items[1].ToString())
                {
                    label7.BackColor = Color.Blue;

                }
                else
                {
                    label7.BackColor = Color.Red;
                }


                //----------------
                if (textBox8.Text == listBox1.Items[2].ToString())
                {
                    label8.BackColor = Color.Blue;

                }
                else
                {
                    label8.BackColor = Color.Red;
                }
                //-----------
                if (textBox9.Text == listBox1.Items[3].ToString())
                {
                    label9.BackColor = Color.Blue;

                }
                else
                {
                    label9.BackColor = Color.Red;
                }



                //---------------
                if (textBox10.Text == listBox1.Items[4].ToString())
                {
                    label10.BackColor = Color.Blue;

                }
                else
                {
                    label10.BackColor = Color.Red;
                }

                if (label9.BackColor == Color.Blue && label10.BackColor == Color.Blue 
                    && label8.BackColor == Color.Blue && label7.BackColor == Color.Blue
                    && label6.BackColor==Color.Blue)
                {
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();

                }




            }

            else if (textBox0.Text == "6")
            {

                if (textBox5.Text == listBox1.Items[0].ToString())
                {
                    label5.BackColor = Color.Blue;

                }
                else
                {
                    label5.BackColor = Color.Red;
                }

                //------------------------

                if (textBox6.Text == listBox1.Items[1].ToString())
                {
                    label6.BackColor = Color.Blue;

                }
                else
                {
                    label6.BackColor = Color.Red;
                }


                //----------------
                if (textBox7.Text == listBox1.Items[2].ToString())
                {
                    label7.BackColor = Color.Blue;

                }
                else
                {
                    label7.BackColor = Color.Red;
                }
                //-----------
                if (textBox8.Text == listBox1.Items[3].ToString())
                {
                    label8.BackColor = Color.Blue;

                }
                else
                {
                    label8.BackColor = Color.Red;
                }



                //---------------
                if (textBox9.Text == listBox1.Items[4].ToString())
                {
                    label9.BackColor = Color.Blue;

                }
                else
                {
                    label9.BackColor = Color.Red;
                }
                //---------------
                if (textBox10.Text == listBox1.Items[5].ToString())
                {
                    label10.BackColor = Color.Blue;

                }
                else
                {
                    label10.BackColor = Color.Red;
                }



                if (label9.BackColor == Color.Blue && label10.BackColor == Color.Blue
                   && label8.BackColor == Color.Blue && label7.BackColor == Color.Blue
                   && label6.BackColor == Color.Blue && label5.BackColor == Color.Blue)
                {
                    MessageBox.Show("oyunu kazandınız");
                    button1.Enabled = false;
                    timer1.Stop();

                }

            }

        }
    }
}
