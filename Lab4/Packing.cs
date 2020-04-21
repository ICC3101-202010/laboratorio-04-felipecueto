using System;
namespace Lab4
{
    public class Packing:Machine
    {
        public Packing()
        {
        }

        private int memory = 5;
  
        public override void On()
        {
            Console.WriteLine("Empaque: Encendido");
        }

        public override void Off()
        {
            Console.WriteLine("Empaque: Apagado");
        }

        public bool PackingProduct()
        {
            if (memory > 0)
            {
                //Console.WriteLine("Empaque: Producto Empaquetado");
                memory -= 1;
            }
            else
            {
                Console.WriteLine("Empaque: Memoria llena");

                return false;

            }
            return true;

        }

        public override void Reboot(Machine machine = null)
        {
            Console.WriteLine("Empaque: Vaciando memoria");
            memory = 5;
            Console.WriteLine("Empaque: Memoria Vacia");

        }
    }
}
