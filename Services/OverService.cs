using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OverAnalysisApp.Models
{
    public class OverService
    {
        private OverAnalysisContext context;

        public OverService()
        {
            context = new OverAnalysisContext();
        }

        public bool AddOverDetails(Over over)
        {
            if(over.OverNumber>6)
            {
                throw new InvalidOverException();     
            }
            else
            {
                context.OverDetails.Add(over);
                context.SaveChanges();
                return true;
            }
        }

        public List<Over> GetOversReport(string bowlerName, DeliveryType deliveryType)
        {
            var overs = context.OverDetails.Where(b => b.BowlerName.Equals(bowlerName) && b.DeliveryTypes==deliveryType).ToList();
            return overs;
        }
    }
}
