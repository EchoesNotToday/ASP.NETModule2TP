using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_module2.BO
{
    class Cercle : Forme
    {
		private int rayon;
		public int Rayon
		{
			get { return rayon; }
			set { rayon = value; }
		}

		public override double Perimetre()
		{
			return this.Rayon*2*Math.PI;
		}

		public override double Aire()
		{
			return (this.Rayon * this.Rayon) * Math.PI;
		}
		public override string ToString()
		{
			return "Cercle de rayon " + this.Rayon + base.ToString();
		}
	}

	
}
