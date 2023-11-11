using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public class Bolge : BaseEntity
	{
		public float KoordinatX { get; set; }
		public float KoordinatY { get; set; }
		public Kita Kitasi { get; set; }
		public List<Sehir> Sehirler { get; set; }
	}
}
