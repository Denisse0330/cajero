using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_Automatico
{
    public class Retiro1 : IRetiro
    {
        public bool retirar(int sifra)
        {
            if ((sifra % 100) == 0 || (sifra % 500) == 0)
            {
                int papeletas500 = 0;
                int papeletas100 = 0;

                while (sifra > 500)
                {
                    papeletas500 = papeletas500 + 1;
                    sifra = sifra - 500;
                }

                while (sifra >= 100)
                {
                    papeletas100 = papeletas100 + 1;
                    sifra = sifra - 100;
                }

                if(papeletas500 > 0)
                {
                    Console.WriteLine("Papeletas de 500: "+ papeletas500);
                }

                if (papeletas100 >0)
                {
                    Console.WriteLine("Papeletas de 100: " + papeletas100);
                }

              //  Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                return true;
            }
            else
            {
                Console.WriteLine("Valor no valido");
                return false;
            }
        }
    }

    public class Retiro3 : IRetiro
    {
        public bool retirar(int sifra)
        {
            if ( (sifra % 200) == 0 || (sifra % 1000) == 0 || (sifra % 100) == 0 || (sifra % 500) == 0)
            {
                int papeletas1000 = 0;
                int papeletas200 = 0;
                int papeletas500 = 0;
                int papeletas100 = 0;

                while (sifra >= 1000)
                {
                    papeletas1000 = papeletas1000 + 1;
                    sifra = sifra - 1000;
                }

                while (sifra >= 500)
                {
                    papeletas500 = papeletas500 + 1;
                    sifra = sifra - 500;
                }


                while (sifra >= 200)
                {
                    papeletas200 = papeletas200 + 1;
                    sifra = sifra - 200;
                }



                while (sifra >= 100)
                {
                    papeletas100 = papeletas100 + 1;
                    sifra = sifra - 100;
                }


                if (papeletas1000 > 0)
                {
                    Console.WriteLine("Papeletas de 500: " + papeletas1000);
                }
                if (papeletas500 > 0)
                {
                    Console.WriteLine("Papeletas de 500: " + papeletas500);
                }

                if (papeletas200 > 0)
                {
                    Console.WriteLine("Papeletas de 200: " + papeletas200);
                }
               

               // Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                return true;
            }
            else
            {
                Console.WriteLine("Valor no valido");
                return false;
            }
        }
    }

    public class Retiro2 : IRetiro
    {
        public bool retirar(int sifra)
        {
            if ((sifra % 200) == 0 || (sifra % 1000) == 0)
            {
                int papeletas1000 = 0;
                int papeletas200 = 0;

                while (sifra >= 1000)
                {
                    papeletas1000 = papeletas1000 + 1;
                    sifra = sifra - 1000;
                }

                while (sifra >= 200)
                {
                    papeletas200 = papeletas200 + 1;
                    sifra = sifra - 200;
                }

                if (papeletas1000 > 0)
                {
                    Console.WriteLine("Papeletas de 1000: " + papeletas1000);
                }

                if (papeletas200 > 0)
                {
                    Console.WriteLine("Papeletas de 200: " + papeletas200);
                }
               
               // Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                return true;
            }
            else
            {
                Console.WriteLine("Valor no valido");
                return false;
            }
        }
    }
}
