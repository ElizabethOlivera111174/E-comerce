using Microsoft.EntityFrameworkCore;
using ProjectNC.Domain.Entities;

namespace ProjectNC.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seeds
            builder.OfferSeed();
            builder.PaymentSeed();
            builder.DeliverySeed();
            builder.ClientSeed();
            builder.ClientDeliverySeed();
            builder.ClientBillingSeed();
            builder.ImageSeed();
            builder.ProductOrederSeed();
            builder.CategorySeed();
            builder.SubCategorySeed();
            builder.UserSeed();
            builder.RolesSeed();
            builder.OrdersSeed();
            builder.CommentProductSeed();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientDelivery> ClientsDelivery { get; set; }
        public DbSet<ClientBilling> ClientsBilling { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CommentProduct> CommentProducts { get; set; }
        public DbSet<Novelty> Novelties { get; set; }   

    }
}
