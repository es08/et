using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Repositories;
using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.BusinessLogic
{
    public class StaffBusinessLogic : IStaffBusinessLogic
    {
        private readonly IStaffRepository staffRepository;

        public StaffBusinessLogic(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }

        public void Create(Staff staff)
        {
            staffRepository.Create(staff);
        }

        public bool Delete(int id)
        {
            return staffRepository.Delete(id);
        }

        public IList<Staff> GetAll()
        {
            return staffRepository.GetAll();
        }

        public Staff GetById(int id)
        {
            return staffRepository.GetById(id);
        }

        public void Update(Staff staff)
        {
            staffRepository.Update(staff);
        }
    }
}
