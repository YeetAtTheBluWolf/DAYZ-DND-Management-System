using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Hachet : Weapon, ITool
    {
        public Hachet() : base(LootRarity.Common, "Hachet", "A small axe with a sharp head", WeaponType.Cutting)
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
