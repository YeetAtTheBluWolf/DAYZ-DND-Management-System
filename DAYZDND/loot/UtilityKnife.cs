using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class UtilityKnife : Weapon, ITool
    {
        public UtilityKnife() : base(LootRarity.Common, "Utility Knife", "A utility knife is any type of knife used for general manual work purposes.", WeaponType.Stabbing)
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
