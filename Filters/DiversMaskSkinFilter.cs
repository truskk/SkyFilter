using System.Collections.Generic;
using hypixel;
using System;

namespace Coflnet.Sky.Filter
{
    public class DiversMaskSkinFilter : SkinFilter
    {
        public override IEnumerable<object> Options => new string[] { "DIVER_PUFFER" };

        public override Func<DBItem, bool> IsApplicable => item => item.Tag == "DIVER_HELMET";
    }
}