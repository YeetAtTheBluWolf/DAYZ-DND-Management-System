using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Screwdriver : Weapon, ITool
    {
        public Screwdriver() : base(LootRarity.Common, "Screwdriver", "A typical simple screwdriver has a handle and a shaft, ending in a tip the user puts into the screw head before turning the handle.", WeaponType.Stabbing)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Utility()
        {
            throw new NotImplementedException();
        }
    }
}
