using System;
namespace Lab4
{
    public class Assembly:Machine
    {
        public Assembly()
        {
        }

        private int memory = 9;

        public override void On()
        {
            Console.WriteLine("Ensamblaje: Encendido");
        }

        public override void Off()
        {
            Console.WriteLine("Ensamblaje: Apagado");
        }

        public bool AssemblyProduct()
        {
            if (memory>0)
            {
                //Console.WriteLine("Ensamblaje: Producto ensamblado");
                memory -= 1;
            }
            else
            {
                Console.WriteLine("Ensamblaje: Memoria llena");
                return false;
                
            }
            return true;

        }

        public override void Reboot(Machine machine = null)
        {
            Console.WriteLine("Ensamblaje: Vaciando memoria");
            memory = 9;
            Console.WriteLine("Ensamblaje: Memoria vacia");
        }

    }
}
