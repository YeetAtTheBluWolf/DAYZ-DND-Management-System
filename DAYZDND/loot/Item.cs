using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public abstract class Item
    {

        public LootRarity Rarity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(LootRarity rarity, string name, string description) 
        {
            Rarity = rarity;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }


    }

}
