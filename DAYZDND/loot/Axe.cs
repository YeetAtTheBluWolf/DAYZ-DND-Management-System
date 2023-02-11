using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Axe : Weapon, ITool
    {
        public Axe() : base(LootRarity.Rare, "Steel Axe", "A sharp axe with a wooden rod and steel axe head.", WeaponType.Cutting)
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
