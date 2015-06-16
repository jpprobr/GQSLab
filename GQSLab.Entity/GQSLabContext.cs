using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GQSLab.Model;

namespace GQSLab.Entity
{
    public class GQSLabContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
    }
}
