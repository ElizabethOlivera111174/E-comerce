using ProjectNC.Domain.Entities;
using System.Threading.Tasks;

namespace ProjectNC.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        // Repositorios

        IBaseRepository<Offer> OffersRepository { get; }
        IBaseRepository<Delivery> DeliveriesRepository { get; }
        IBaseRepository<Payment> PaymentsRepository { get; }
        IBaseRepository<Product> ProductsRepository { get; }
        IBaseRepository<ProductOrder> ProductOrderRepository {get;}
        IBaseRepository<Category> CategoriesRepository { get; }
        IBaseRepository<Client> ClientsRepository { get; }
        IBaseRepository<ClientDelivery> ClientsDeliveryRepository { get; }
        IBaseRepository<ClientBilling> ClientsBillingRepository { get; }
        IBaseRepository<Image> ImagesRepository { get; }
        IBaseRepository<User> UsersRepository { get; }
        IBaseRepository<Role> RolesRepository { get; }
        IBaseRepository<Order> OrdersRepository { get; }
        IBaseRepository<SubCategory> SubCategoriesRepository { get; }
        IBaseRepository<CommentProduct> CommentProductRepository { get; }
        IBaseRepository<Novelty> NoveltiesRepository { get; }

        // Common Methods
        void SaveChanges();
        Task SaveChangesAsync();
        void Dispose();
    }
}
