using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Hacksaw : Weapon, ITool
    {
        public Hacksaw() : base(LootRarity.Uncommon, "Hacksaw", "A hacksaw is a fine-toothed saw, originally and mainly made for cutting metal.", WeaponType.Cutting)
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
