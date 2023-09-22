using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_12
{
    abstract public class Storage
    {
      

        public string Name { get; set; }
        public string Model { get; set; }

        protected Storage(string name, string model)
        {
            Name = name;
            Model = model;
        }

        protected Storage()
        {
           
        }

        public abstract void MediaTipiniOlcusu();

        public abstract void Copy(double newFile);


        public abstract double FreeMemory();

        public abstract void PrintDeviceİnfo();

    }
}
