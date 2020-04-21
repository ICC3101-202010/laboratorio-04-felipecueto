using System;
namespace Lab4
{
    public class CentralComputer:IOn,IOff,IReboot

    {
        Reception reception = new Reception();
        Storage storage = new Storage();
        Assembly assembly = new Assembly();
        Check check = new Check();
        Packing packing = new Packing();

        public CentralComputer()
        {

        }

        public void On()
        {
            Console.WriteLine("Encender Maquinas\n");
            reception.On();
            System.Threading.Thread.Sleep(1000);
            storage.On();
            System.Threading.Thread.Sleep(1000);
            assembly.On();
            System.Threading.Thread.Sleep(1000);
            check.On();
            System.Threading.Thread.Sleep(1000);
            packing.On();
            System.Threading.Thread.Sleep(1000);
            StartWorking();
            Console.WriteLine("\n");


        }

        public void StartWorking() //Una vez las maquinas esten encedidad deben partir trabajadando y consumiendo memoria
        {
            int i = 0;
            while (i<10) 
            {
                System.Threading.Thread.Sleep(2000);

                if (!reception.ReceptionProduct())
                {
                    Reboot(reception);
                    reception.ReceptionProduct();
                }
                if (!storage.StorageProduct())
                {
                    Reboot(storage);
                    storage.StorageProduct();
                }
                if (!assembly.AssemblyProduct())
                {
                    Reboot(assembly);
                    assembly.AssemblyProduct();
                }
                if (!check.CheckProduct())
                {
                    Reboot(check);
                    check.CheckProduct();
                }
                if (!packing.PackingProduct())
                {
                    Reboot(packing);
                    packing.PackingProduct();
                }

                i++;
                Console.WriteLine("\n");
            }
            Off();
        }
        
        public void Off()
        {
            Console.WriteLine("Apagar Maquinas\n");
            reception.Off();
            System.Threading.Thread.Sleep(1000);
            storage.Off();
            System.Threading.Thread.Sleep(1000);
            assembly.Off();
            System.Threading.Thread.Sleep(1000);
            check.Off();
            System.Threading.Thread.Sleep(1000);
            packing.Off();
            System.Threading.Thread.Sleep(1000);

        }

        public void Reboot(Machine machine)
        {
            machine.Reboot();
           
        }


    }


}
