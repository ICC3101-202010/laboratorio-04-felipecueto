using System;
namespace Lab4
{
    public class Storage:Machine
    {
        

        public Storage()
        {
        }
 
        private int memory = 4;
        

        public override void On()
        {
            Console.WriteLine("Almacenamiento: Encendido");
        }

        public override void Off()
        {
            Console.WriteLine("Almacenamiento: Apagado");
        }

        public bool StorageProduct()
        {
            if (memory > 0)
            {
                //Console.WriteLine("Almacenamiento: Producto Guardado");
                memory -= 1;
            }
            else
            {
                Console.WriteLine("Almacenamiento: Memoria llena");
                return false;
                
            }
            return true;
        }

        public override void Reboot(Machine machine = null)
        {
            Console.WriteLine("Almacenamiento: Vaciando memoria");
            memory = 4;
            Console.WriteLine("Almacenamiento: Memoria vacia ");
        }
    }
}
