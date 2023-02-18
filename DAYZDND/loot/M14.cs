using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class M14 : Weapon, IFirearm
    {
        public M14() : base(LootRarity.Rare, "M14", "The M14 rifle, officially the United States Rifle, Caliber 7.62 mm, M14, is an American selective-fire battle rifle chambered for the 7.62×51mm NATO (.308 in) cartridge.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Rifle;
            Ammo = new Ammo[] { loot.Ammo._308 };
        }

        public FirearmType FirearmType { get { return FirearmType; } set {} }
        public Ammo[] Ammo { get { return Ammo; } set {} }

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
