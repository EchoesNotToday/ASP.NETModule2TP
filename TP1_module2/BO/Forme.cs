using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_module2.BO
{
    abstract class Forme
    {
        public abstract double Perimetre();

        public abstract double Aire();

        public override string ToString()
        {
            return " Aire = " + Aire() + " Périmètre =" + Perimetre();
        }
    }

    
}
