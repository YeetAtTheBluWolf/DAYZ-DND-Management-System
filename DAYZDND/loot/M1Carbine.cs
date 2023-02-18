using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class M1Carbine : Weapon, IFirearm
    {
        public M1Carbine() : base(LootRarity.Uncommon, "M1 Carbine", "The M1 carbine (formally the United States Carbine, Caliber .30, M1) is a lightweight[8] semi-automatic carbine that was a standard firearm for the U.S. military during World War II, the Korean War and the Vietnam War.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Rifle;
            Ammo = new Ammo[] { loot.Ammo._30cal };
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
