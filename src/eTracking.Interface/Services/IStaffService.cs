using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Services
{
    public interface IStaffService
    {
        IList<Staff> GetAll();
        Staff GetById(int id);
        void Create(Staff staff);
        void Update(Staff staff);
        bool Delete(int id);
    }
}
