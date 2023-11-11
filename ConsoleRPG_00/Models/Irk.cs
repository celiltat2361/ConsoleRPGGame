using ConsoleRPG_00.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleRPG_00.Models
{
	public class Irk : BaseEntity, IStat
	{
		public Irk(string isim)
		{
			Isim = isim;
			switch (Isim.ToLower())
			{
				case "insan":
					IradeModifikasyonu = 1;
					break;
				case "ork":
					GucModifikasyonu = 2;
					break;
				case "elf":
					CeviklikModifikasyonu = 1;
					break;
				case "cuce":
					DayaniklikModifikasyonu = 2;
					break;
				case "undead":
					GucModifikasyonu = 3;
					IradeModifikasyonu = 1;
					break;
				default:
					break;
			}
		}

		public void StatBelirle(Karakter k)
		{
			switch (Isim.ToLower())
			{
				case "insan":
					k.Irade += IradeModifikasyonu;
					break;
				case "ork":
					k.Guc += GucModifikasyonu;
					break;
				case "elf":
					k.Ceviklik += CeviklikModifikasyonu;
					break;
				case "cuce":
					k.Dayaniklik += DayaniklikModifikasyonu;
					break;
				case "undead":
					k.Guc += GucModifikasyonu;
					k.Irade += IradeModifikasyonu;
					break;
				default:
					break;
			}
		}
		public int GucModifikasyonu { get; set; }
		public int CeviklikModifikasyonu { get; set; }
		public int IradeModifikasyonu { get; set; }
		public int DayaniklikModifikasyonu { get; set; }
		public List<Karakter> Karakterler { get; set; }
		public Sehir BaslangicSehri { get; set; }
	}
}
