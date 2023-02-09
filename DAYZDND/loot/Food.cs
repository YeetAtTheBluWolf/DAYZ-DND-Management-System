using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public abstract class Food : Item
    {

        public bool Spoiled { get; set; }
        public FoodType Type { get; set; }

        public Food(LootRarity lootRarity, string name, string description, bool isSpoiled, FoodType type) : base (lootRarity, name, description)
        {
            Type = type;
            Spoiled = isSpoiled;
        }

        public abstract void Filling();

    }
}
