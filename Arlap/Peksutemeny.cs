using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arlap
{
	internal abstract class Peksutemeny : Arlapp
	{
		private double alapar;
		private double mennyiseg;

		public Peksutemeny(double alapar, double mennyiseg)
		{
			this.alapar = alapar;
			this.mennyiseg = mennyiseg;
		}
		public double Alapar {set => alapar = value; }
		public int cseszekave { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		protected double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

		public abstract void Megkostol(); 

		public int MennyibeKerul()
		{
			return (int)(this.alapar * this.mennyiseg); 
		}
		public override string ToString()
		{
			return $"{this.mennyiseg}: {this.MennyibeKerul}";
		}

	}
}
