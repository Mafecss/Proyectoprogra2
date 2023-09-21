using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoprogra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int num1, num2;
            num1 = 56;
            byte b = 255;
            short cortos = 65;
            float flotante = 3.14f;
            double dobles = 56.11452366555554444d;
            decimal deci = 569.45m;
            long largo = 13131313131313131;
            Boolean boleano = true; //falso y verdadero
            string cadena = "Hoy es miercoles 27 de sept";
            char caracter = 's';

            //tipos de datos dinamicos (var y dynamics)

            var variable = 20;
            dynamic dinamica = 30;
            dinamica = true;
            dinamica = "Hola mundo";
            dinamica = 'b';

            int resultado;
            num1 = 5;
            num2 = 8;
            resultado = num1 + num2;
            Console.WriteLine(resultado);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La suma es de:" + (num1 + num2));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("La resta de {1}-{1} es de: {2}", num1, num2, num1 - num2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"La multiplicacion de {num1} * {num2}={num1 * num2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------");

            //Final
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el monto del prestamo");
            float monto = float.Parse(Console.ReadLine());
            if (monto <= 500000)
            {
                monto = monto * 1.05f;
                Console.WriteLine("Digite los meses");
                int meses = int.Parse(Console.ReadLine());
                float cuota = monto / meses;
                Console.WriteLine($"el monto a pagar por mes es de {cuota} con un interes del 5%");
                Console.WriteLine();
            }
            else if (monto > 500000 && monto <= 1000000)
            {
                monto = monto * 1.13f;
                Console.WriteLine("Digite los meses");
                int meses = int.Parse(Console.ReadLine());
                float cuota = monto / meses;
                Console.WriteLine($"el monto a pagar por mes es de {cuota} con un interes del 13%");
                Console.WriteLine();
            }




            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Digite su nombre");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Digite el monto del prestamo");
            //float monto = float.Parse(Console.ReadLine());  // convertir texto a flotante
            //int edad = int.Parse(Console.ReadLine()); // convertir texto a entero
            //double salario = double.Parse(Console.ReadLine()); //convertir texto a doble
            //byte dias = byte.Parse(Console.ReadLine()); // convertir texto a byte
            //string meses = mes.ToString(); //convertir un numero a texto
            //string meses2 = Convert.ToString(mes);

            Console.ReadLine();

        }
    }
        
    }
