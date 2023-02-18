using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Winchester : Weapon, IFirearm
    {
        public Winchester() : base(LootRarity.Rare, "Winchester", "It has an iconic place in American sporting culture and has been held in high regard by shooters since it was introduced in 1936, earning the moniker \"The Rifleman's Rifle\".", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Bolt_Action_Sniper;
            Ammo = new Ammo[] { loot.Ammo._22hornetcal };
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
