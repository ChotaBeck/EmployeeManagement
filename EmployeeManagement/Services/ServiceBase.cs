using EmployeeManagement.Data;
using EmployeeManagement.Interface;

namespace EmployeeManagement.Services
{
    public class ServiceBase<T> : ICrud<T> where T:class
    {
        readonly ApplicationDbContext context;
        protected IQueryable<T> Entities {get => context.Set<T>();}
        public ServiceBase(ApplicationDbContext _context)
        {
            context = _context;
        }
        public bool Add(T entity)
        {   
            try
            {
                context.Set<T>().Add(entity);
                return context.SaveChanges() != 0;
            }
            catch 
            {
              return false;
            }
            
        }

        public bool Delete(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                return context.SaveChanges() != 0;
            }
            catch 
            {
              return false;
            }
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
           try
            {
                context.Set<T>().Update(entity);
                return context.SaveChanges() != 0;
            }
            catch 
            {
              return false;
            }
        }
    }
}