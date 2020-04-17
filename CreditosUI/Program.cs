using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace creditoUI
{
    class Program
    {


        static Credito credito;

        static void Main(string[] args)
        {
            string tipoCredito = null;

            Console.WriteLine("Tipo de credito");
            tipoCredito = Console.ReadLine();
            

            if (tipoCredito.Equals("simple"))
            {
                Registrar();
                credito = new CreditoSimple(credito.Identificacion, credito.Nombre, credito.CapitalInicial, credito.TasaInteres, credito.TiempoTranscurrido, credito.TipoCredito);
                
                credito.CalcularValorPagar();
            }
            else if (tipoCredito.Equals("compuesto"))
            {
                Registrar();
                credito = new CreditoCompuesto(credito.Identificacion, credito.Nombre, credito.CapitalInicial, credito.TasaInteres, credito.TiempoTranscurrido, credito.TipoCredito);
                
                credito.CalcularValorPagar();
            }
        }

        private static void Registrar()
        {
            Console.WriteLine("Identificación: ");
            credito.Identificacion = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            credito.Nombre = Console.ReadLine();
            Console.WriteLine("Capital inicial: ");
            credito.CapitalInicial = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tasa interes: ");
            credito.TasaInteres = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tiempo transcurrido: ");
            credito.TiempoTranscurrido = Convert.ToUInt32(Console.ReadLine());
        }
    }
       

}








/* public static void Menu()
        {
            int opcion;
            do
            {
                Console.WriteLine(".: MENU :.");
                Console.WriteLine("1 .. Registrar");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Registro();
                        break;
                    default:
                        Console.WriteLine("La opción es incorrecta, intente nuevamente");
                        break;
                }
            } while (opcion != 5);
        }
        public static void Registro()
        {
            int opcion;
            Console.WriteLine(".: REGISTRO :.");
            Console.WriteLine("1 .. Credito compuesto");
            Console.WriteLine("2 .. Cresito simple");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    RegistroCompuesto();
                    break;
                case 2:
                    RegistroSimple();
                    break;
                default:
                    Console.WriteLine("La opción es incorrecta, intente nuevamente");
                    break;
            }
        }
        public static void RegistroCompuesto()
        {
            credito = new CreditoCompuesto();
            Console.WriteLine("Identificación: ");
            credito.Identificacion = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            credito.Nombre = Console.ReadLine();
            Console.WriteLine("Capital inicial: ");
            credito.CapitalInicial = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tasa interes: ");
            credito.TasaInteres = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tiempo transcurrido: ");
            credito.TiempoTranscurrido = Convert.ToUInt32(Console.ReadLine());

            credito.CalcularValorPagar();
            Console.WriteLine($"Total a pagar: {credito.TotalPagar}");
        }
        public static void RegistroSimple()
        {
            credito = new CreditoSimple();
            Console.WriteLine("Identificación: ");
            credito.Identificacion = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            credito.Nombre = Console.ReadLine();
            Console.WriteLine("Capital inicial: ");
            credito.CapitalInicial = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tasa interes: ");
            credito.TasaInteres = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Tiempo transcurrido: ");
            credito.TiempoTranscurrido = Convert.ToUInt32(Console.ReadLine());

            credito.CalcularValorPagar();
            Console.WriteLine($"Total a pagar: {credito.TotalPagar}");
        }

    }*/
