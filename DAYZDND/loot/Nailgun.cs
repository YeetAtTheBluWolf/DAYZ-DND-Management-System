using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Nailgun : Weapon, IFirearm, ITool
    {

        public Nailgun() : base(LootRarity.Uncommon, "Nailgun", "A nail gun, nailgun or nailer is a form of hammer used to drive nails into wood or other materials.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Pistol;
            Ammo = new Ammo[] { loot.Ammo.Nails };
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

        public void Utility()
        {
            throw new NotImplementedException();
        }
    }
}
