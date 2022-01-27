using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using hypixel;

namespace Coflnet.Sky.Filter
{
    public class StarsFilter : GeneralFilter
    {
        public override FilterType FilterType => FilterType.Equal | FilterType.SIMPLE;

        public override IEnumerable<object> Options => new object[] { "none", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public override Func<DBItem, bool> IsApplicable => item
            => (item?.Category == Category.WEAPON)
            || item.Category == Category.ARMOR;


        public override Expression<Func<SaveAuction, bool>> GetExpression(FilterArgs args)
        {
            var key = NBT.Instance.GetKeyId("dungeon_item_level");
            var stringVal = args.Get(this);
            if (int.TryParse(stringVal, out int val))
                return a => a.NBTLookup.Where(l => l.KeyId == key && l.Value == val).Any();
            return a => !a.NBTLookup.Where(l => l.KeyId == key).Any();
        }
    }
}

