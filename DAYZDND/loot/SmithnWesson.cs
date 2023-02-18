using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class SmithnWesson : Weapon, IFirearm
    {
        public SmithnWesson() : base(LootRarity.Rare, "Smith and Wesson", "The Smith & Wesson Model 10, previously known as the Smith & Wesson .38 Hand Ejector Model of 1899, the Smith & Wesson Military & Police or the Smith & Wesson Victory Model, is a K-frame revolver of worldwide popularity.", WeaponType.Bludgeoning)
        {
            FirearmType = FirearmType.Revolver;
            Ammo = new Ammo[] { loot.Ammo._32cal };
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
