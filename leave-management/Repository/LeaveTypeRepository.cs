using System.Collections.Generic;
using System.Linq;
using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db=db;
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
             return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
             return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
           var LeaveTypes = _db.LeaveTypes.ToList();
           return LeaveTypes;
        }

        public LeaveType FindById(int id)
        {
            var LeaveTypes = _db.LeaveTypes.Find(id);
            return LeaveTypes;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            var changes =_db.SaveChanges();
            return changes >0;

            
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
            //save
        }
    }
}