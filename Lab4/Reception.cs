using System;
namespace Lab4
{
    public class Reception: Machine
    {  
        public Reception()
        {

        }
        private int memory = 2;
     
        public override void On()
        {
            Console.WriteLine("Recepcion: Encendido");
        }

        public override void Off()
        {
            Console.WriteLine("Recepcion: Apagado");
        }

        public bool ReceptionProduct()
        {
            if (memory > 0)
            {
                //Console.WriteLine("Recepion: Producto Recivido");
                memory -= 1;
            }
            else
            {
                Console.WriteLine("Recepion: Memoria llena");
                return false;
            }

            return true;

        }

        public override void Reboot(Machine machine = null)
        {
            Console.WriteLine("Recepcion: Vaciando memoria memoria");
            memory = 2;
            Console.WriteLine("Recepcion: Memoria Vacia");

        }

       


    }
}
