using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_module2.BO
{
    class Triangle : Forme
    {
		private int a;
		private int b;
		private int c;

		public int C
		{
			get { return c; }
			set { c = value; }
		}

        public int B
		{
			get { return b; }
			set { b = value; }
		}


		public int A
		{
			get { return a; }
			set { a = value; }
		}

		public override double Perimetre()
		{
			return this.A + this.B + this.C;
		}

		public override double Aire()
		{
			double p = this.Perimetre() / 2;
			return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
		}

		public override string ToString()
		{
			return "Triangle de côté A = " + this.A + ", B=" + this.B + " C=" + this.C +base.ToString();
		}
	}
}
