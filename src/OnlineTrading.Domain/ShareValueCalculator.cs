using System.Linq;
using System.Collections.Generic;
using System;

namespace OnlineTrading.Domain
{
    public class ShareValueCalculator
    {
        private List<Share> shares {get;set; } = new List<Share>();

        public void AddShares(IEnumerable<Share> sharesToAdd) {
            shares.AddRange(sharesToAdd);
        }

        public decimal CalculateTotalValue() {
            return shares.Sum(s => s.UnitPrice * s.Quantity);
        }

        public bool QualifiesForGoldClub(IEnumerable<Share> shares)
        {
            var total = shares.Sum(s => s.UnitPrice * s.Quantity);

            return total > 50;
        }
        
        public Share GetLowestValueShare()
        {
            var lowestValueShare = shares.OrderBy(s => s.Quantity * s.UnitPrice).FirstOrDefault();

            return lowestValueShare;
        }
    }
}