using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arlap
{
	internal class Pogacsa : Peksutemeny
	{
		public Pogacsa(double alapar, double mennyiseg) : base(alapar, mennyiseg)
		{



		}
		public override void Megkostol()
		{
			if (this.Mennyiseg > 0)
			{
				this.Mennyiseg--;
				Console.WriteLine("nyam nyam nyam");
			}
			else 
			{
				throw new Exception("Noincs már több the éhes!Egyel mekibe:O");
			}
			
		}
		public override string ToString()
		{
			return "Pogacsa" + base.ToString();
		}


	}
}
