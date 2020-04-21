using System;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CentralComputer centralComputer = new CentralComputer();
          
            Console.WriteLine("Bienvenido a la Fábrica orientada a objetos\n");
            System.Threading.Thread.Sleep(1000);
            centralComputer.On();
            
        }

    }
}
