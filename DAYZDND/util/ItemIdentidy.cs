using DAYZDND.loot;

namespace DAYZDND.util
{
    public class ItemIdentidy
    {

        private readonly Dictionary<int, Item> items = new();

        public ItemIdentidy() 
        {
            items.Add(0, new AR15());
            items.Add(1, new Axe());
            items.Add(2, new BoltCutters());
            items.Add(3, new ColtPython());
            items.Add(4, new Drill());
            items.Add(5, new Hachet());
            items.Add(6, new Hacksaw());
            items.Add(7, new Hammer());
            items.Add(8, new M14());
            items.Add(9, new M1911());
            items.Add(10, new M1Carbine());
            items.Add(11, new Mallet());
            items.Add(12, new MarlinModel60());
            items.Add(13, new Mossberg500());
            items.Add(14, new MultiTool());
            items.Add(15, new Nailgun());
            items.Add(16, new Pickaxe());
            items.Add(17, new Remington700());
            items.Add(18, new Remington870());
            items.Add(19, new Ruger77());
            items.Add(20, new Scissor());
            items.Add(21, new Screwdriver());
            items.Add(22, new Shovel());
            items.Add(23, new Sledgehammer());
            items.Add(24, new SmithnWesson());
            items.Add(25, new UtilityKnife());
            items.Add(26, new Winchester());
            items.Add(27, new Wrench());
        }

        public Item GetItem(int ItemID)
        {
            return items[ItemID];
        }

        public string GetItemList()
        {
            string str = "";
            for(int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                str += i + ": " + item.Name + "\n";
            }
            return str;
        }

    }
}
