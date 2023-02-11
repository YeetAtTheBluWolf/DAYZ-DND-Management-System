using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class AR15 : Weapon, IFirearm
    {
        public AR15(WeaponType weaponType) : base(LootRarity.Rare, "AR-15", "An AR-15-style rifle is any lightweight semi-automatic rifle based on or similar to the Colt AR-15 design.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Rifle;
            Ammo = new Ammo[] { loot.Ammo._223rem };
        }

        public FirearmType FirearmType { get { return FirearmType; } set { FirearmType = value; } }
        public Ammo[] Ammo { get { return Ammo; } set { Ammo = value; } }

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
