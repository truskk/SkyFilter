using System;
using System.Linq;
using System.Linq.Expressions;
using Coflnet.Sky.Core;

namespace Coflnet.Sky.Filter;
public class EndAfterFilter : DateTimeFilter
{
    protected override Expression<Func<SaveAuction, bool>> GetComparison(DateTime timestamp)
    {
        return a => a.End > timestamp;
    }
}
