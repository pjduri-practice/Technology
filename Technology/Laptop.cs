using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public int NumOfUsb { get; set; }

        public Laptop(int numOfUsb, double ram, double screenSize, string oS) : base(ram, screenSize, oS)
        {
            NumOfUsb = numOfUsb;
        }

        public void StuffedCheetos(int numOfCheetos)
        {
            NumOfUsb -= numOfCheetos;
        }
    }
}
