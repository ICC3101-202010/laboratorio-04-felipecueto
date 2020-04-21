using System;
namespace Lab4
{
    public class Check:Machine
    {
        public Check()
        {
        }
       
        private int memory = 8;
        
        public override void On()
        {
            Console.WriteLine("Verificación: Encendido");
        }

        public override void Off()
        {
            Console.WriteLine("Verificación: Apagado");
        }

        public bool CheckProduct()
        {
            if (memory > 0)
            {
                //Console.WriteLine("Verificación: Producto Verificado");
                memory -= 1;
            }
            else
            {
                Console.WriteLine("Verificación: Memoria llena");
                return false;
                
            }
            return true;
        }

        public override void Reboot(Machine machine = null)
        {
            Console.WriteLine("Ensamblaje: Vaciando memoria");
            memory = 8;
            Console.WriteLine("Ensamblaje: Memoria vacia");

        }
    }
}
