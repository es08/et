using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.BusinessLogics
{
    public interface IStaffBusinessLogic
    {
        IList<Staff> GetAll();
        Staff GetById(int id);
        void Create(Staff staff);
        void Update(Staff staff);
        bool Delete(int id);
    }
}
