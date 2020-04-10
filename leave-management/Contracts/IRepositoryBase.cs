using System.Collections.Generic;
using leave_management.Data;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T:class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
	
	
	
	
	
}