using BlogCoreSolution.AccesoDatos.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogCoreSolution.AccesoDatos.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // Contexto de la base de datos
        protected readonly DbContext Context;
        internal DbSet<T> dbSet;

        // Constructor
        public Repository(DbContext context)
        {
            Context = context;
            dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string? includeProperties = null)
        {
            // Se inicia la consulta con el DbSet
            IQueryable<T> query = dbSet;

            // Aplicar filtro
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Incluir propiedades de navegación
            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(
                    new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty.Trim());
                }
            }

            // Aplicar ordenamiento
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public T GetFirstOrDefault(
            Expression<Func<T, bool>>? filter = null,
            string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            // Aplicar filtro
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Incluir propiedades de navegación
            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(
                    new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty.Trim());
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entityToRemove = dbSet.Find(id);

            if (entityToRemove != null)
            {
                dbSet.Remove(entityToRemove);
            }
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}