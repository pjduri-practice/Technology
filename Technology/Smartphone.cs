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

        public Smartphone(bool hasCamera, double ram, double screenSize, string oS) : base(ram, screenSize, oS)
        {
            HasCamera = hasCamera;
        }

        public void DropPhone()
        {
            HasCamera = false;
        }
    }
}
