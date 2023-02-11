using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYZDND.loot
{
    public class TestItem : Item
    {
        public TestItem() : base(LootRarity.Common, "Test", "Test Description")
        {
        }
    }
}
