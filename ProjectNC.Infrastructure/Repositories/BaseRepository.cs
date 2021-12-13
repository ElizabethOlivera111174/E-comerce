using Microsoft.EntityFrameworkCore;
using ProjectNC.Domain.Entities;
using ProjectNC.Infrastructure.Data;
using ProjectNC.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectNC.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _entity;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            var request = await _entity.Where(x => x.Active == false && x.Id == id)
                .FirstOrDefaultAsync();

            return request;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            var response = await _entity.Where(x => x.Active == false).ToListAsync();
            return response;
        }
        public async Task Insert(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.Active = false;

            await _entity.AddAsync(entity);
        }
        public async Task Update(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            _context.Update(entity);
        }
        public async Task Delete(int id)
        {
            var entity = await _entity.FindAsync(id);

            entity.Active = true;
            entity.CreatedAt = DateTime.Now;

            _entity.Update(entity);
        }
        public bool EntityExists(int id)
        {
            var request = _entity.Any(x => x.Id == id && x.Active == false);
            return request;
        }

        #region AboutFindByCondition
        /// <summary>
        /// Metodo para realizar una busqueda por medio de una expresion LINQ
        /// </summary>
        /// <remarks>
        /// <para>Ejemplo:
        /// var request= _unitOfWork.(repositorioDeLaEntidad).FindByCondition(x=> x.campo del objeto de la Db == Campo contra el que quiero comparar);</para>
        /// <para>Cuando se quiere agregar una entidad ligada por una FK, se debe de incluir despues de la frase, con una coma</para>
        /// <para>Ejemplo: .FindByCondition(query LINQ, y=> y.EntidadVinculadaPorunaFK)</para>
        /// <para> Ejemplo concreto:
        /// var request= _unitOfWork.UsersRepository.FindByCondition(x=> x.Email == email, y=> y.Role);</para>
        /// <para> Esto me va a traer un IEnumerable de User, y en el campo Role va a traer el Rol asignado a ese Usuario.
        /// De ahi solamente restaria aplicar logica para hacerlo lista, o para lo que necesiten</para>
        /// 
        /// </remarks>
        /// <returns>
        /// IEnumerable de la entidad que se este ocupando, filtrada. Pueden agregarse mas propiedades. 
        /// Por defecto trae solo las que IsDeleted==false
        /// </returns> 
        #endregion
        public async Task<IEnumerable<T>> FindByCondition
            (Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var response = _entity
                .Where(x => x.Active == false)
                .Where(predicate);

            foreach (var includeProperty in includeProperties)
            {
                response = response.Include(includeProperty);
            }

            return await response.ToListAsync();
        }
    }
}
