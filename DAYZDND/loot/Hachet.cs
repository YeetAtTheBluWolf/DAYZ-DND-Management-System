using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class Hachet : Weapon, ITool
    {
        public Hachet(LootRarity rarity, string name, string description, WeaponType weaponType) : base(rarity, name, description, weaponType)
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
