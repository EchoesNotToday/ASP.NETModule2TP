using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_module2.BO
{
    class Carre : Forme
    {
		private int longueur;

		public int Longueur
		{
			get { return longueur; }
			set { longueur = value; }
		}

		public override double Perimetre()
		{
			return this.Longueur * 4;
		}

		public override double Aire()
		{
			return this.Longueur * this.Longueur;
		}

		public override string ToString()
		{
			return "Carré de côté " + Longueur + base.ToString();
		}
	}
}
