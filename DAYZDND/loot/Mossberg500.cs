using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Mossberg500 : Weapon, IFirearm
    {
        public Mossberg500() : base(LootRarity.Uncommon, "Mossberg 500", "The Mossberg 500 (M500) is a series of pump action shotguns manufactured by O.F. Mossberg & Sons.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Shotgun;
            Ammo = new Ammo[] { loot.Ammo._12Gauge, loot.Ammo._20Gauge };
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
