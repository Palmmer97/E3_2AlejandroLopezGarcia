using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2AlejandroLopezGarcia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea la cola 
            Queue miCola = new Queue();
            // for para llenar la Cola 
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Introdur el valor de cola: ");
                //  lee el valor introducido para despues guardar en la variable de tipo Var para posterior realizar llamada al elemento
                var Elem = Console.ReadLine();
                // llamar a la funcion Enqueue para guardar las variables del elemento que se le asignan.
                miCola.Enqueue(Elem); 
            }
            // Se elimina el primer elemento de la cola
            miCola.Dequeue();
            // Foreach para imprimir los elementos de la cola
            foreach (var Elemento in miCola) 
            {
                Console.WriteLine(Elemento);
            }
            // Establece la capacidad en el numero real de elementos que hay en la cola
            miCola.TrimToSize(); 
            Console.ReadKey();
        }
    }
}
