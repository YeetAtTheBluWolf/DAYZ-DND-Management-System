using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Shovel : Weapon, ITool
    {
        public Shovel() : base(LootRarity.Uncommon, "Shovel", "A shovel is a tool used for digging, lifting, and moving bulk materials, such as soil, coal, gravel, snow, sand, or ore.", WeaponType.Stabbing)
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
