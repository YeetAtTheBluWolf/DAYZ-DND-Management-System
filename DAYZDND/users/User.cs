using DAYZDND.loot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.users
{
    public class User
    {

        public string Name { get; private set; }
        public string Description { get; set; }
        public ArrayList Inventory { get; set; }
        public int ZombieKills { get; private set; }

        public User(String name)
        {
            Name = name;
            Description = "";
            Inventory = new ArrayList();
            ZombieKills = 0;
        }

        public string GetInv()
        {
            if (Inventory.Count <= 0)
                return "Your inventory is empty.";
            string str = "";
            for(int i = 0; i < Inventory.Count; i++)
            {
                str += Inventory[i] + "\n";
            }
            return "Inventory: \n" + str;
        }

        public void AddToInv(Item item)
        {
            Inventory.Add(item);
        }

        public void AddKills(int kills)
        {
            ZombieKills += kills;
        }

        public override string ToString()
        {
            return Name + "\n" + Description + "\nZombie Kills: " + ZombieKills; 
        }

    }
}
