using System;
using System.Collections.Generic;
using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Services;
using eTracking.Model;

namespace eTracking.Service
{
    public class StaffService : IStaffService
    {
        private readonly IStaffBusinessLogic staffBusinessLogic;

        public StaffService(IStaffBusinessLogic staffBusinessLogic)
        {
            this.staffBusinessLogic = staffBusinessLogic;
        }

        public void Create(Staff staff)
        {
            staffBusinessLogic.Create(staff);
        }

        public bool Delete(int id)
        {
           return staffBusinessLogic.Delete(id);
        }

        public IList<Staff> GetAll()
        {
            return staffBusinessLogic.GetAll();
        }

        public Staff GetById(int id)
        {
            return staffBusinessLogic.GetById(id);
        }

        public void Update(Staff staff)
        {
            staffBusinessLogic.Update(staff);
        }
    }
}
