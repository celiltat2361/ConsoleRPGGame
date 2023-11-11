using ConsoleRPG_00.Enums;
using ConsoleRPG_00.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_00.Models
{
	public abstract class Esya : BaseEntity, IStat
	{
		public List<BonusÖzellik> BonusOzellikler { get; set; }

		public int Bonus { get; set; }

		public virtual void StatBelirle(Karakter k)
		{
			foreach (BonusÖzellik item in BonusOzellikler)
			{
				switch (item)
				{
					case BonusÖzellik.Guc:
						k.Guc += Bonus;
						break;
					case BonusÖzellik.Irade:
						k.Irade += Bonus;
						break;
					case BonusÖzellik.Ceviklik:
						k.Ceviklik += Bonus;
						break;
					case BonusÖzellik.Dayaniklik:
						k.Dayaniklik += Bonus;
						break;
				}

			}
		}
	}
}
