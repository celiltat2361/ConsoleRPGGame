using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public class Karakter : KarakterYaratikSpec
	{
		public Karakter(Sinif sinif, Irk irk)
		{
			Seviye= 1;
			MaxCan = MevcutCan = 100;
			MaxEnerji = MevcutEnerji = 50;
			Sinifi = sinif;
			Irk = irk;
			

			sinif.StatBelirle(this);
			irk.StatBelirle(this);
			Defans = 10 + Dayaniklik + Seviye;
		}

		

		int _maxCan;
		public override int MaxCan 
		{
			get
			{
				if (Seviye == 1 && _maxCan != 100)
				{
					throw new Exception("Karakater 1. seviyede olmasina ragmen bir problem var");
				}
				return _maxCan;
			}

			set
			{
				if (Seviye == 1 && value == 100)
				{
					_maxCan = value;
				}
				else if( Seviye > 1 && value > _maxCan) 
				{
					_maxCan= value;
				} 
				else
				{
					throw new Exception("Karakterin can puaniyla ilgili bir problem olustu");
				}
				
			} 
		}

		int _maxEnerji;

		public override int MaxEnerji 
		{ 
			get
			{
				if (Seviye == 1 && _maxEnerji != 50)
				{
					throw new Exception("Karakterin enerji seviyesinde 1.seviyede olan bir karakter icin uygun deger yok");
				}
				return _maxEnerji;
			}

			set
			{
				if (Seviye == 1 && value == 50)
				{
					_maxEnerji = value;
				}
				else if (Seviye > 1 && value > _maxEnerji)
				{
					_maxEnerji = value;
				}
				else
				{
					throw new Exception("Karakterin enerji seviyesi ile ilgili bir problem olustu.");
				}
			}
		}
		
		

		//Stats - abilities
		public int Guc { get; set; }
		public int Ceviklik { get; set; }
		public int Irade { get; set; }
		public int Dayaniklik { get; set; }

		public int Para { get; set; }

		//Equipment
		public Silah Silahi { get; set; }
		public Zirh Zirhi { get; set; }
		public Tilsim Tilsimi { get; set; }


		public int Seviye { get; set; }
		public Sinif Sinifi { get; set; }
		public Irk Irk { get; set; }



		public override int YakinSaldiri()
		{
			int saldiri = Sinifi.Isim == "savasci" || Sinifi.Isim == "sovalye" ? rnd.Next(1, 21) : rnd.Next(1, 10);

			if (Silahi != null) return saldiri + Guc + Seviye + Silahi.Hasar;
			return saldiri + Guc + Seviye;
		}

		public override void OzelSaldiri()
		{
			throw new NotImplementedException();
		}

		public override int UzakSaldiri()
		{
			int saldiri = Sinifi.Isim == "okcu" || Sinifi.Isim == "ninja" ? rnd.Next(1, 21) : rnd.Next(1, 10);

			if (Silahi != null) return saldiri + Ceviklik + Silahi.Hasar;
			return saldiri + Ceviklik + Seviye;
		}
	}
}
