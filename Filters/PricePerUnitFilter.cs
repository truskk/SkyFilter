using System;
using System.Linq.Expressions;
using Coflnet.Sky.Core;

namespace Coflnet.Sky.Filter;

public class PricePerUnitFilter : NumberFilter
{
    public override Expression<Func<SaveAuction, long>> GetSelector(FilterArgs args)
    {
        return a => a.StartingBid / (a.Count == 0 ? 1 : a.Count);
    }
}