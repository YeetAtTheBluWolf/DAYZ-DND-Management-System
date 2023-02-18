using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Remington700 : Weapon, IFirearm
    {
        public Remington700() : base(LootRarity.Common, "Remington 700", "The Remington Model 700 is a series of bolt-action centerfire rifles manufactured by Remington Arms since 1962.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Rifle;
            Ammo = new Ammo[] { loot.Ammo._308 };
        }

        public FirearmType FirearmType { get { return FirearmType; } set { } }
        public Ammo[] Ammo { get { return Ammo; } set { } }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
