using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingresa tu edad:");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else 
            {
                Console.WriteLine("A dormir. Eres menor de edad");
            }
            int dia_semana;
            Console.Write("Ingresa el numero del dia de la semana [entre 1 y 7]");
            dia_semana = int.Parse(Console.ReadLine());
            if (dia_semana == 1)
                Console.WriteLine("Es lunes");
            else if (dia_semana == 2)
                Console.WriteLine("Es Martes");
            else if (dia_semana == 3) 
            {
                Console.WriteLine("Es Miercoles");
                Console.WriteLine("Dia de solteros y solteras");
            }
              
            else if (dia_semana == 4)
                Console.WriteLine("Es Jueves");
            else if (dia_semana == 5)
                Console.WriteLine("Es Viernes");
            else if (dia_semana == 6)
                Console.WriteLine("Es Sabado");
            else if (dia_semana == 7)
                Console.WriteLine("Es Domingo");
            else
                Console.WriteLine("Dato incorrecto...");

            Console.ReadKey();
        }
    }
}
