using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public abstract class KarakterYaratikSpec : BaseEntity
	{
		protected Random rnd;
		public KarakterYaratikSpec()
		{
			rnd= new Random();
		}
		public virtual int MaxCan { get; set; }
		public virtual int MaxEnerji { get; set;}
		public int MevcutCan { get; set; }
		public int MevcutEnerji { get; set; }
		public virtual int TecrubePuani { get; set; }
		public int Defans { get; set; }

		public virtual int YakinSaldiri() 
		{
			return rnd.Next(1, 21);
		}

		public abstract void OzelSaldiri();

		public virtual int UzakSaldiri()
		{
			return rnd.Next(1, 11);
		}

	}
}
