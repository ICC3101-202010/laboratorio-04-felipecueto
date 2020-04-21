using System;
namespace Lab4
{
    abstract public class Machine: IOn, IOff, IReboot
    {
        protected int Memory { get; set; }
        abstract public void On();
        abstract public void Off();
        abstract public void Reboot(Machine machine = null);
        
       
    }
}
