using eTracking.Interface.Repositories;
using eTracking.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eTracking.DAL.Repositories
{
    public class MajorRepository : IMajorRepository
    {
        private readonly ETrackingContext context;
        //private readonly IMapper mapper;

        public MajorRepository(ETrackingContext context)
        {
            this.context = context;
        }

        public void Create(Major major)
        {
            context.Majors.Add(major);
            Save();
        }

        public bool Delete(int id)
        {
            var obj = context.Majors.Find(id);
            var result = false;
            if (obj != null)
            {
                context.Majors.Remove(obj);
                Save();
                result = true;
            }

            return result;
        }

        public IList<Major> GetAll()
        {
            return context.Majors.AsNoTracking().ToList<Major>();
        }

        public Major GetById(int id)
        {
            return context.Majors.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Major major)
        {
            context.Entry(major).State = EntityState.Modified;
            Save();
        }
    }
}
