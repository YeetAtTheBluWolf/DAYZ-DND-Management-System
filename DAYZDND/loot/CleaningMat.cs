using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public abstract class CleaningMat : Item
    {
        public CleaningMat(LootRarity rarity, string name, string description) : base(rarity, name, description)
        {
        }

        public abstract void Apply();

    }
}
