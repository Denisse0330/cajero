using System;

namespace Cajero_Automatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Menuprincipal();
        }
        public static void Menuprincipal()
        {
            int Mododedispensacion = 3;



            try
            {
                Console.WriteLine("Seleccione la opcion que desea realizar:");
                Console.WriteLine("");
                Console.WriteLine("1- configuracion del modo de dispensacion del cajero.");
                Console.WriteLine("2- Retiro de dinero.");
                int Opcion = Convert.ToInt32(Console.ReadLine());

                if (Opcion == 1)
                {
                    Console.WriteLine("1- Este cajero solo dispensa papeleta 200 y 1,000.");
                    Console.WriteLine("2- Este cajero solo dispensa papeleta 100 y 500.");
                    Console.WriteLine("3- Tambien puede obtener la menor papeleta posible.");
                    Mododedispensacion = Convert.ToInt32(Console.ReadLine());
                }

                if (Opcion == 2)
                {
                    Console.WriteLine("Ingrese la sifra que desea retirar: ");
                    int sifra = Convert.ToInt32(Console.ReadLine());



                    if (Mododedispensacion == 3)
                    {
                        Console.WriteLine("Usted a retirado la suma de: " + sifra);

                        if ((sifra % 100) == 0 || (sifra % 500) == 0 || (sifra % 200) == 0 || (sifra % 1000) == 0)
                        {
                            Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                        }
                        else
                        {
                            Console.WriteLine("Valor no valido");
                        }

                    }
                    //////
                    else if (Mododedispensacion == 1)
                    {
                        if ((sifra % 200) == 0 && (sifra % 1000) == 0)
                        {
                            Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                        }
                        else
                        {
                            Console.WriteLine("Monto incorrecto, solo dispensa papeleta de 200 y 1000.");
                        }
                    }
                    else if (Mododedispensacion == 2)
                    {
                        if ((sifra % 100) == 0 && (sifra % 500) == 0)
                        {
                            Console.WriteLine("Usted a dispensado la suma de: " + sifra);
                        }
                        else
                        {
                            Console.WriteLine("Monto incorrecto, solo dispensa papeleta de 100 y 500");
                        }
                    }


                }
            }
            catch (Exception)
            {
                Console.WriteLine("Seleccione una opcion valida");

            }

            }
            }
    }

           

