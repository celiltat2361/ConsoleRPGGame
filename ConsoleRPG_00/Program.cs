
using ConsoleRPG_00.Models;
using System.Net;
using System.Net.WebSockets;
using System.Security;

namespace ConsoleRPG_00
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Sinif savasci = new Sinif("savasci");
			Sinif okcu = new Sinif("okcu");
			Sinif buyucu = new Sinif("buyucu");
			Sinif sovalye = new Sinif("sovalye");
			Sinif ninja = new Sinif("ninja");

			Irk insan = new Irk("insan");
			Irk elf = new Irk("elf");
			Irk ork = new Irk("ork");
			Irk cuce = new Irk("cuce");
			Irk undead = new Irk("undead");

			Console.WriteLine("giris icin isim girin");
			string isim = Console.ReadLine();
			Console.WriteLine("sifre giriniz");
			string sifre = Console.ReadLine();

			if (isim == "celil" && sifre == "123")
			{
				Console.WriteLine("hosgeldiniz, karakter ismi giriniz");
			}
			else
			{
				Console.WriteLine("kullanici bulunamadi!!!");
			}

			string karakterIsmi = Console.ReadLine();
			string sinifSecimi;
			Sinif secilenSinif = null;

			do
			{
				Console.WriteLine("Karakterin sinifini seciniz: \n1:Savasci\n2:Okcu\n3:Buyucu\n4:Sovalye\n5:Ninja...Farkli bir secimde ilerleyemezseniz");
				sinifSecimi = Console.ReadLine();

				switch (sinifSecimi)
				{
					case "1":
						secilenSinif = savasci;
						break;
					case "2":
						secilenSinif = okcu;
						break;
					case "3":
						secilenSinif = buyucu;
						break;
					case "4":
						secilenSinif = sovalye;
						break;
					case "5":
						secilenSinif = ninja;
						break;
				}

			} while (sinifSecimi != "1" && sinifSecimi != "2" && sinifSecimi != "3" && sinifSecimi != "4" && sinifSecimi != "5");

			string irkSecimi;
			Irk secilenIrk = null;

			do
			{
				Console.WriteLine("Irkinizi seciniz...\n1:Insan\n2:Ork\n3:Cuce\n4:Elf\n5:Undead...Farkli bir secimde ilerleyemezsin");
				irkSecimi = Console.ReadLine();
				switch (irkSecimi)
				{
					case "1":
						secilenIrk = insan;
						break;
					case "2":
						secilenIrk = ork;
						break;
					case "3":
						secilenIrk = cuce;
							break;
					case "4":
						secilenIrk = elf;
						break;
					case "5":
						secilenIrk = undead;
						break;
				}

			} while (irkSecimi != "1" && irkSecimi != "2" && irkSecimi != "3" && irkSecimi != "4" && irkSecimi != "5");

			Karakter k = new Karakter(secilenSinif, secilenIrk);
			k.Isim = isim;

			Console.WriteLine($"Karakterinizin ismi => {k.Isim}...Karakterinizin sinifi => {k.Sinifi.Isim}...Irkiniz => {k.Irk.Isim}...Defansimiz => {k.Defans}...Seviyeniz => {k.Seviye}");

			string oyunModu;
			do
			{
				Console.WriteLine("ne yapmak istiyorsunuz? 1. Macera\n2. Dinlenmek\n3:Görev\n4:Cikis");
				oyunModu = Console.ReadLine();
				if (oyunModu == "1" )
				{
					Yaratik y = new Yaratik();
					
					y.Defans = k.Seviye * 10;
					y.MevcutCan = y.MaxCan = k.Seviye * 50;

					Console.WriteLine($"Karsiniza cikan yaratigin cani => {y.MaxCan}, Defansi => {y.Defans}..Saldiri basliyor lutfen secim yapin.. \n1.Yakin Saldiri\n2.Uzak Saldiri");
					string saldiriSecimi = Console.ReadLine();

					bool dovusDevam = true;

					do
					{

						switch (saldiriSecimi)
						{
							case "1":
							default:
								int yakinSaldiri = k.YakinSaldiri() - y.Defans;
								if (yakinSaldiri <= 0) 
								{
									yakinSaldiri = 0;
								}
								else
								{
									y.MevcutCan -= yakinSaldiri;
								}
								int yaratikSaldirisi = y.YakinSaldiri() - k.Defans;
								if (yaratikSaldirisi <= 0) yaratikSaldirisi = 0;
								k.MevcutCan -= yaratikSaldirisi;
								break;
							case "2":
								int uzakSaldiri = k.UzakSaldiri() - y.Defans;
								if (uzakSaldiri <= 0)
								{
									uzakSaldiri = 0;
								}
								else
								{
									y.MevcutCan -= uzakSaldiri;
								}
								int yaratikUzakSaldirisi = y.UzakSaldiri() - k.Defans;
								if (yaratikUzakSaldirisi <= 0) yaratikUzakSaldirisi = 0;
								k.MevcutCan -= yaratikUzakSaldirisi;
								break;
						}
						if (y.MevcutCan <= 0)
						{
							Console.WriteLine("Tebrikler kazandin");
							dovusDevam = false;
							continue;
						}

						Console.WriteLine($"Saldiri yapildi...yaratigin kalan cani => {y.MevcutCan}..Sizin caniniz {k.MevcutCan}...Devam etmek istiyor musunuz?\n1:Devam, 2:Cikis, varsayilan devam");
						string macera = Console.ReadLine();
						switch (macera)
						{
							case "2":
								dovusDevam = false;
								break;
						}

					} while (dovusDevam);
				}
				else if (oyunModu == "5")
				{
					Console.WriteLine("Maceradan cikiliyor");
					break;
				}

			} while (oyunModu != "1" && oyunModu != "2" && oyunModu != "3" && oyunModu != "4" && oyunModu != "5");

			//Console.ReadLine();
		}
	}
}