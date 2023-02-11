using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Mallet : Weapon, ITool
    {
        public Mallet() : base(LootRarity.Uncommon, "Mallet", "A mallet is a tool used for imparting force on another object, often made of rubber or sometimes wood, that is smaller than a maul or beetle, and usually has a relatively large head.", WeaponType.Bludgeoning)
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
