using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Repositories
{
    public interface IStaffRepository
    {
        IList<Staff> GetAll();
        Staff GetById(int id);
        void Create(Staff staff);
        void Update(Staff staff);
        bool Delete(int id);
        void Save();
    }
}
