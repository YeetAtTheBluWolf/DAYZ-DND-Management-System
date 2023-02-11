using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    internal class Sledgehammer : Weapon, ITool
    {
        public Sledgehammer() : base(LootRarity.Rare, "Sledgehammer", "The long handle combined with a heavy head allows the sledgehammer to gather momentum during a swing and apply a large force compared to hammers designed to drive nails.", WeaponType.Bludgeoning)
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
