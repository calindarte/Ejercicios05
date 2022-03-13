using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios05
{
    class Program
    {
        static void Main (string[] args)
        { /* Pedir el nombre de la semana al usuario y decir si es fin de semana o no, y en caso de error indicarlo*/
            Console.SetCursorPosition(20, 4); Console.Write("Escribe un dia de la semana: ");
            string dia = Console.ReadLine();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.SetCursorPosition(20, 6); Console.WriteLine("Es fin de semana");
             }

            else
            {
                Console.SetCursorPosition(20, 6); Console.WriteLine(" el dia " + dia + " no es fin de semana");
            }
            Console.ReadLine(); 

        }
            
        }
    }

