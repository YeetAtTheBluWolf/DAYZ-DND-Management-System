using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Wrench : Weapon, ITool
    {
        public Wrench() : base(LootRarity.Uncommon, "Wrench", "A wrench or spanner is a tool used to provide grip and mechanical advantage in applying torque to turn objects—usually rotary fasteners, such as nuts and bolts—or keep them from turning.", WeaponType.Bludgeoning)
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
