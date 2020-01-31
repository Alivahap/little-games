using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_oyunu
{
    class Seviye
    {

         double cevap,sayi1,sayi2;
       

        public double Sayi1
        {
            get
            {
                return sayi1;
            }
            set
            {
                sayi1 = value;
            }

        }

        public double Sayi2
        {
            get
            {
                return sayi2;
            }
            set
            {
                sayi2 = value;
            }

        }



        public double Cevap(int soru, int seviye)
        {
            //ilk 5 soru toplama
            if (soru >= 1 && soru <= 5)
            {
                Random r1 = new Random();

                //seviye 1 deki sayı aralığı 
                if (seviye == 1)
                {
                    sayi1 = r1.Next(0, 9);
                    sayi2 = r1.Next(0, 9);

                }
                //seviye 2 deki sayı aralığı 
                else if (seviye == 2)
                {
                    sayi1 = r1.Next(5, 20);
                    sayi2 = r1.Next(5, 20);

                }
                //seviye 3 deki sayı aralığı 
                else if (seviye == 3)
                {
                    sayi1 = r1.Next(15, 50);
                    sayi2 = r1.Next(15, 50);

                }

                else if (seviye == 4)
                {
                    sayi1 = r1.Next(25, 100);
                    sayi2 = r1.Next(25, 100);

                }
                else if (seviye == 5)
                {
                    sayi1 = r1.Next(50, 200);
                    sayi2 = r1.Next(50, 200);

                }









                cevap = sayi1 + sayi2;

            }

            //sonraki 5. ile 10. sorular çıkartma işlemine tabi tutulur
            else if (soru >= 6 && soru <= 10)
            {
                Random rn = new Random();


                //-----------seviye ikide sayılar artsın

                if (seviye == 1)//seviye 1 deki sayı aralığı 
                {
                    sayi1 = rn.Next(0, 9);
                    Sayi2 = rn.Next(0, 9);
                    while (sayi2 > sayi1)
                    {
                        sayi2 = rn.Next(0, 9);
                    }

                }
                //seviye 2 deki sayı aralığı
                else if (seviye == 2)
                {
                    sayi1 = rn.Next(5, 20);
                    sayi2 = rn.Next(5, 20);
                    while (sayi2 > sayi1)
                    {
                        sayi2 = rn.Next(5, 20);
                    }


                }
                //seviye 3 deki sayı aralığı
                else if (seviye == 3)
                {

                    sayi1 = rn.Next(15, 50);
                    Sayi2 = rn.Next(15, 50);
                    while (sayi2 > sayi1)
                    {
                        sayi2 = rn.Next(15, 50);
                    }

                }
                else if (seviye == 4)
                {

                    sayi1 = rn.Next(25, 100);
                    Sayi2 = rn.Next(25, 100);
                    while (sayi2 > sayi1)
                    {
                        sayi2 = rn.Next(25, 100);
                    }


                }
                else if (seviye == 5)
                {

                    sayi1 = rn.Next(50, 200);
                    Sayi2 = rn.Next(50, 200);
                    while (sayi2 > sayi1)
                    {
                        sayi2 = rn.Next(50, 200);
                    }

                }






                cevap = Sayi1 - sayi2;


            }
            //çarpma işlemi soru 10 ile 15 arasında yapılır 
            else if (soru >= 11 && soru <= 15)
            {
                Random rn = new Random();
                if (seviye == 1)
                {
                    Sayi1 = rn.Next(0, 5);
                    sayi2 = rn.Next(0, 5);



                }
                else if (seviye == 2)
                {
                    Sayi1 = rn.Next(1, 7);
                    sayi2 = rn.Next(0, 7);



                }
                else if (seviye == 3)
                {
                    Sayi1 = rn.Next(5, 9);
                    sayi2 = rn.Next(5, 9);



                }
                else if (seviye == 4)
                {
                    Sayi1 = rn.Next(10, 15);
                    sayi2 = rn.Next(10, 15);



                }
                else if (seviye == 5)
                {
                    Sayi1 = rn.Next(15, 25);
                    sayi2 = rn.Next(15, 25);



                }
                cevap = sayi1 * sayi2;

            }
        
            

            else if (soru>=16 && soru <= 20)
            {
                
              
                Random rn = new Random();
                if (seviye == 1)
                {
                    sayi1 = rn.Next(1, 9);
                    sayi2 = rn.Next(1, 9);
                    while(sayi1 % sayi2 != 0)
                    {
                        Sayi2 = rn.Next(1, 9);
                    }

                 

                    

                }

               else if (seviye == 2)
                {
                    sayi1 = rn.Next(1, 15);
                    sayi2 = rn.Next(1, 15);
                    while (sayi1 % sayi2 != 0)
                    {
                        sayi2 = rn.Next(1, 15);
                    }





                }

                else if (seviye == 3)
                {
                    sayi1 = rn.Next(1, 30);
                    sayi2 = rn.Next(1, 30);

                    while (sayi1 % sayi2 != 0)
                    {
                        sayi2 = rn.Next(5, 30);
                    }





                }
                else if (seviye == 4)
                {
                    sayi1 = rn.Next(1, 50);
                    sayi2 = rn.Next(1, 50);
                    while (sayi1 % sayi2 != 0)
                    {
                        sayi2 = rn.Next(15, 50);
                    }





                }
                else if (seviye == 5)
                {
                    sayi1 = rn.Next(1, 100);
                    sayi2 = rn.Next(1, 100);
                    while (sayi1 % sayi2 != 0)
                    {
                        sayi2 = rn.Next(30, 100);
                    }





                }



                cevap = sayi1 / Sayi2;







            }






            return cevap;
        }


    }
}
