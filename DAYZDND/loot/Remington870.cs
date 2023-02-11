using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    internal class Remington870 : Weapon, IFirearm
    {
        public Remington870() : base(LootRarity.Uncommon, "Remington 870", "It is widely used by the public for shooting sports, hunting and self-defense, as well as by law enforcement and military organizations worldwide.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Shotgun;
            Ammo = new Ammo[] { loot.Ammo._12Gauge };
        }

        public FirearmType FirearmType { get { return FirearmType; } set => FirearmType = value; }
        public Ammo[] Ammo { get { return Ammo; } set => Ammo = value; }

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
