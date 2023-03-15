using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Smartphone : Computer
    {
        public bool HasCamera { get; set; } = true;

        public Smartphone(double ram, double screenSize, string oS) : base(ram, screenSize, oS)
        {
        }

        public void DropPhone()
        {
            HasCamera = false;
        }
    }
}
