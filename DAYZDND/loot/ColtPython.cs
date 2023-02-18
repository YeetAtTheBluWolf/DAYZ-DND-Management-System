using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    internal class ColtPython : Weapon, IFirearm
    {
        public ColtPython() : base(LootRarity.Common, "Colt Python", "The Colt Python is a .357 Magnum caliber revolver manufactured by Colt's Manufacturing Company of Hartford, Connecticut. It was first introduced in 1955, the same year as Smith & Wesson's M29 .44 Magnum. ", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Revolver;
            Ammo = new Ammo[] { loot.Ammo._357 };
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
