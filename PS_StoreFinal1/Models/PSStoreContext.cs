namespace PS_StoreFinal1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PSStoreContext : DbContext
    {
        public PSStoreContext()
            : base("name=PSStoreConnection")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<Soup> Soups { get; set; }

        public virtual DbSet<Appetizer> Appetizers { get; set; }

        public virtual DbSet<DimSum> DimSums { get; set; }

        public virtual DbSet<Entree> Entrees { get; set; }

        public virtual DbSet<Special> Specials { get; set; }

    }
}
