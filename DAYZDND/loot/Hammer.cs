using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Hammer : Weapon, ITool
    {
        public Hammer() : base(LootRarity.Uncommon, "Hammer", "A hammer is a tool, most often a hand tool, consisting of a weighted \"head\" fixed to a long handle that is swung to deliver an impact to a small area of an object.", WeaponType.Bludgeoning)
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
