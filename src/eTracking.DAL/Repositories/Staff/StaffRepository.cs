using eTracking.Interface.Repositories;
using eTracking.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eTracking.DAL.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ETrackingContext context;
        //private readonly IMapper mapper;

        public StaffRepository(ETrackingContext context)
        {
            this.context = context;
        }

        public void Create(Staff project)
        {
            context.Staffs.Add(project);
            Save();
        }

        public bool Delete(int id)
        {
            var obj = context.Staffs.Find(id);
            var result = false;
            if (obj != null)
            {
                context.Staffs.Remove(obj);
                Save();
                result = true;
            }

            return result;
        }

        public IList<Staff> GetAll()
        {
            return context.Staffs.Include(i => i.Major).Include(i => i.Position).AsNoTracking().ToList<Staff>();
        }

        public Staff GetById(int id)
        {
            return context.Staffs.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Staff position)
        {
            context.Entry(position).State = EntityState.Modified;
            Save();
        }
    }
}
