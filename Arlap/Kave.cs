using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arlap
{
	internal class Kave : Arlapp
	{

		private bool habosE;

		public Kave(bool habosE)
		{
			this.habosE = habosE;
			
		}

		public int cseszekave { get => 180; set => cseszekave = value ; }

		public int MennyibeKerul()
		{
			return habosE ? ((int)(cseszekave * 1.5)) : cseszekave;
		}
	}
}
