using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Ruger77 : Weapon, IFirearm
    {

        public Ruger77() : base(LootRarity.Uncommon, "Ruger Model 77", "The Ruger 77/22 is a bolt-action rimfire rifle chambered for the .22 Long Rifle, .22 WMR, or .22 Hornet.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Bolt_Action_Sniper;
            Ammo = new Ammo[] { loot.Ammo._425express };
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
