using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public abstract class Medicine : Item
    {

        public bool Spoiled { get; set; }

        public Medicine(LootRarity rarity, string name, string description) : base(rarity, name, description)
        {

        }

        public abstract void Apply();
        public abstract void Prescription();

    }
}
