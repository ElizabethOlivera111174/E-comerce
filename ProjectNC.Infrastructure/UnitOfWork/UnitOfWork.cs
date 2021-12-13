using ProjectNC.Domain.Entities;
using ProjectNC.Infrastructure.Data;
using ProjectNC.Infrastructure.Interfaces;
using ProjectNC.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace ProjectNC.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        #region Repository and Implementations
        //Implementaciones
        private readonly IBaseRepository<Offer> _offersRepository;
        private readonly IBaseRepository<Delivery> _deliveriesRepository;
        private readonly IBaseRepository<Payment> _paymentsRepository;
        private readonly IBaseRepository<Category> _categoriesRepository;
        private readonly IBaseRepository<Client> _clientsRepository;
        private readonly IBaseRepository<ClientDelivery> _clientsDeliveryRepository;
        private readonly IBaseRepository<ClientBilling> _clientsBillingRepository;
        private readonly IBaseRepository<Product> _productsRepository;
        private readonly IBaseRepository<ProductOrder> _productoOrderRepository;
        private readonly IBaseRepository<Image> _imagesRepository;
        private readonly IBaseRepository<User> _usersRepository;
        private readonly IBaseRepository<Role> _rolesRepository;
        private readonly IBaseRepository<Order> _ordersRepository;
        private readonly IBaseRepository<SubCategory> _subCategoriesRepository;
        private readonly IBaseRepository<CommentProduct> _commentsProductRepository;
        private readonly IBaseRepository<Novelty> _noveltiesRepository;

        //Repositorios
        public IBaseRepository<Offer> OffersRepository => _offersRepository ?? new BaseRepository<Offer>(_context);
        public IBaseRepository<Delivery> DeliveriesRepository => _deliveriesRepository ?? new BaseRepository<Delivery>(_context);
        public IBaseRepository<Payment> PaymentsRepository => _paymentsRepository ?? new BaseRepository<Payment>(_context);
        public IBaseRepository<Category> CategoriesRepository => _categoriesRepository ?? new BaseRepository<Category>(_context);
        public IBaseRepository<Client> ClientsRepository => _clientsRepository ?? new BaseRepository<Client>(_context);
        public IBaseRepository<ClientDelivery> ClientsDeliveryRepository => _clientsDeliveryRepository ?? new BaseRepository<ClientDelivery>(_context);
        public IBaseRepository<ClientBilling> ClientsBillingRepository => _clientsBillingRepository ?? new BaseRepository<ClientBilling>(_context);   
        public IBaseRepository<Product> ProductsRepository => _productsRepository ?? new BaseRepository<Product>(_context);
        public IBaseRepository<Image> ImagesRepository => _imagesRepository ?? new BaseRepository<Image>(_context);
        public IBaseRepository<User> UsersRepository => _usersRepository ?? new BaseRepository<User>(_context);
        public IBaseRepository<Role> RolesRepository => _rolesRepository ?? new BaseRepository<Role>(_context);
        public IBaseRepository<Order> OrdersRepository => _ordersRepository ?? new BaseRepository<Order>(_context);
        public IBaseRepository<SubCategory> SubCategoriesRepository => _subCategoriesRepository ?? new BaseRepository<SubCategory>(_context);
        public IBaseRepository<ProductOrder> ProductOrderRepository => _productoOrderRepository ?? new BaseRepository<ProductOrder>(_context);
        public IBaseRepository<CommentProduct> CommentProductRepository => _commentsProductRepository ?? new BaseRepository<CommentProduct>(_context);
        public IBaseRepository<Novelty> NoveltiesRepository => _noveltiesRepository ?? new BaseRepository<Novelty>(_context);

        #endregion

        #region UnitOfWorkMethods
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
        #endregion
    }
}
