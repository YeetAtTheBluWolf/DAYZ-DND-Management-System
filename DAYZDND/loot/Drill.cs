using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Drill : Weapon, ITool
    {
        public Drill() : base(LootRarity.Uncommon, "DRILL", "BRRRRRRRR BRING BRING BRRRRRRR", WeaponType.Stabbing)
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
