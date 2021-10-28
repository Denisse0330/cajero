using System;

namespace Cajero_Automatico
{
    class Program
    {
        private int dispensacion = 3;

        IRetiro retiro;
        static void Main(string[] args)
        {
            var x = new Program();
            x.runCajero();
        }

        public void runCajero()
        {
            if (this.menu1() == 1)
            {
              this.dispensacion=   this.menu2();
            }

            if (this.evaluar() == 1)
            {
                this.dispensar();
            }
            else
            {
                this.runCajero();
            }
        }

        public int evaluar()
        {
            if (dispensacion == 1)
            {
                this.retiro = new Retiro2();
               
            }
            else if (dispensacion == 2)
            {
                this.retiro = new Retiro1();
            }
            else if (dispensacion == 3)
            {
                this.retiro = new Retiro3();
            }
            else
            {
                Console.WriteLine("Seleccione la opcion que valida:");
                return 0;
            }
            return 1;
        }


        public void dispensar()
        {
            try
            {
                Console.WriteLine("Digitar la sifra que desea retirar:");
                int sifra = Convert.ToInt32(Console.ReadLine());
                if (this.retiro.retirar(sifra))
                {

                }
                Console.WriteLine("1- Iniciar Nuevamente?");
                Console.WriteLine("!= 1 Salir");
                if (Console.ReadLine() == "1")
                {
                    this.runCajero();
                }


            }
            catch
            {

            }

        }

        public int menu1()
        {
            Console.WriteLine("Seleccione la opcion que desea realizar:");
            Console.WriteLine("");
            Console.WriteLine("1- configuracion del modo de dispensacion del cajero.");
            Console.WriteLine("2- Retiro de dinero.");
            return Convert.ToInt32(Console.ReadLine());
        }


        public int menu2()
        {
            Console.WriteLine("1- Este cajero solo dispensa papeleta 200 y 1,000.");
            Console.WriteLine("2- Este cajero solo dispensa papeleta 100 y 500.");
            Console.WriteLine("3- Tambien puede obtener la menor papeleta posible.");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
    }

           

