using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OverAnalysisApp.Models
{
    public class OverAnalysisContext : DbContext
    {
        public OverAnalysisContext() : base("OverAnalysisConnection")
        {

        }

        public virtual DbSet<Over> OverDetails { get; set; }
    }
}
