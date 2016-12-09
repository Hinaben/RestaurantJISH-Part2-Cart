namespace RestaurantJISH.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantEntities : DbContext
    {
        public RestaurantEntities()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<menus> FoodItems { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.FoodItems)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurants>()
                .HasMany(e => e.Categories)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<RestaurantJISH.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}
