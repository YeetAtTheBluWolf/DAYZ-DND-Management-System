using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class BoltCutters : Weapon, ITool
    {
        public BoltCutters() : base(LootRarity.Rare, "Bolt Cutters", "Bolt Cutters ready to cut fences", WeaponType.Bludgeoning)
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
