using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_12
{
    public class DVD : Storage
    {

        public float Read_WriteSureti { get; set; }

        private double Memory;

        public double Files { get; set; }

        public double MemoryTerefi
        {
            get { return Memory; }

            set
            {

                if (value == 1) Memory = 4.7;
                else if (value == 2) Memory = 9;
            }
        }


        public DVD(string name, string model,float read_WriteSureti, double files, double memoryTerefi) : base(name, model)
        {
            Read_WriteSureti = read_WriteSureti;
            Files = files;
            MemoryTerefi = memoryTerefi;
        }

        public DVD()
        {
        }

        public override void Copy(double newFile)
        {
            Console.WriteLine($"NECE VAXDA YUKLENECEYI: {newFile / Read_WriteSureti}");
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
            Console.WriteLine($"Ne Qeder Memory De Yor Qalib: {Memory - Files}");
            Console.WriteLine($"Sureti: {Read_WriteSureti}\n");
        }
    }
}
