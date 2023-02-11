using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class MultiTool : Weapon, ITool
    {
        public MultiTool() : base(LootRarity.Rare, "Multi-Tool", "A multi-tool (or multitool) is a hand tool that combines several individual functions in a single unit.", WeaponType.Stabbing)
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
