using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public abstract class BaseEntity
	{
		public string Isim { get; set; }
		public DateTime VeriYapmaTarihi { get; set; }
		public DateTime? VeriDegistirmeTarihi { get; set; }
		public DateTime? VeriSilmeTarihi { get; set; }

	}
}
