using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class M1911 : Weapon, IFirearm
    {
        public M1911() : base(LootRarity.Common, "M1911", "he M1911 (Colt 1911 or Colt Government) is a single-action, recoil-operated, semi-automatic pistol chambered for the .45 ACP cartridge.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Pistol;
            Ammo = new Ammo[] { loot.Ammo._45acp };
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
