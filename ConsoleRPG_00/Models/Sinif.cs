using ConsoleRPG_00.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public class Sinif : BaseEntity, IStat
	{
		public Sinif(string isim)
		{
			Isim = isim;
		}

		public void StatBelirle(Karakter k)
		{
			switch (Isim.ToLower())
			{
				case "savasci":
					k.Guc = 3;
					k.Dayaniklik = 3;
					k.Ceviklik = 2;
					k.Irade = 1;
					break;
				case "okcu":
					k.Guc = 2;
					k.Dayaniklik = 2;
					k.Ceviklik = 3;
					k.Irade = 1;
					break;
				case "buyucu":
					k.Guc = 1;
					k.Dayaniklik = 1;
					k.Ceviklik = 2;
						k.Irade = 3;
					break;
				case "sovalye":
					k.Guc = 3;
					k.Dayaniklik = 2;
					k.Ceviklik = 1;
					k.Irade = 3;
					break;

				case "ninja":
					k.Guc = 2;
					k.Dayaniklik = 2;
					k.Ceviklik = 3;
					k.Irade = 2;
					break;

			}

			
		}

		public List<Karakter> Karakterler { get; set; }
	}
}
