using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_module2.BO
{
    class Rectangle : Forme
    {
		private int longueur;
		private int largeur;

		public int Largeur
		{
			get { return largeur; }
			set { largeur = value; }
		}

		public int Longueur
		{
			get { return longueur; }
			set { longueur = value; }
		}
		

		public override double Perimetre()
		{
			return (Longueur + Largeur) * 2;
		}

		public override double Aire()
		{
			return Longueur * Largeur;
		}

		public override string ToString()
		{
			return "Rectangle de longueur=" + Longueur + " et largeur=" + Largeur + base.ToString();
		}
	}
}
