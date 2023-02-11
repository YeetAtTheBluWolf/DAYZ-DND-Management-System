using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Pickaxe : Weapon, ITool
    {
        public Pickaxe() : base(LootRarity.Rare, "Pickaxe", "A pickaxe, pick-axe, or pick is a generally T-shaped hand tool used for prying.", WeaponType.Stabbing)
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
