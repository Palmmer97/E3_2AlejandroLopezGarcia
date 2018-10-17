using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2AlejandroLopezGarcia
{
    class Desarrollo
    {
        // declarando la cola
        private Queue Kcola; 
        public void Cola()
        {
            // inicializando la cola
            Kcola = new Queue(); 
        }
        // Se añade el objeto  de cualquier tipo a la lista
        public void EnQueue(object item) 
        {
            //  objeto de cualquier tipo de dato.
            Kcola.Enqueue(item); 
        }

        public void DeQueue()
        {
            // Se elimina el valor en la posicion 0 del arraylist
            Kcola.Dequeue();
        }
    }
}
