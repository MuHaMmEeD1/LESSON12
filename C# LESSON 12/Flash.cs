using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_12
{
    public class Flash : Storage
    {
        public Flash()
        {
        }

        public Flash(string name, string model,float uSBSureti, double memory, double files) : base(name, model)
        {
            USBSureti = uSBSureti;
            Memory = memory;
            Files = files;
        }

        public float USBSureti { get; set; }
        public double Memory { get; set; }  
        public double Files { get; set; }
        
      

        public override void Copy(double newFile)
        {
            Console.WriteLine($"NECE VAXDA YUKLENECEYI: {newFile/USBSureti}");
        } 

        public override double FreeMemory()
        {
            return Memory - Files;
        }

        public override void MediaTipiniOlcusu()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Memory: {Memory}");
        }

        public override void PrintDeviceİnfo()
        {
            Console.WriteLine($"Adi: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Memory: {Memory}");
            Console.WriteLine($"Ne Qeder Memory De Yor Dolub: {Files}");
            Console.WriteLine($"Ne Qeder Memory De Yor Qalib: {Memory-Files}");
            Console.WriteLine($"Sureti: {USBSureti}\n");
        }
    }
}
