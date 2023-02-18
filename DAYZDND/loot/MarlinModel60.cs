using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class MarlinModel60 : Weapon, IFirearm
    {
        public MarlinModel60() : base(LootRarity.Common, "Marlin Model 60", "The Marlin Model 60, also known as the Marlin Glenfield Model 60, is a semi-automatic rifle that fires the .22 LR rimfire cartridge.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Rifle;
            Ammo = new Ammo[] { loot.Ammo._35rem };
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
