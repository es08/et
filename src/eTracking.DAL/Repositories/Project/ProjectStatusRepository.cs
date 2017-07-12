using eTracking.Interface.Repositories;
using eTracking.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eTracking.DAL.Repositories
{
    public class ProjectStatusRepository : IProjectStatusRepository
    {
        private readonly ETrackingContext context;
        //private readonly IMapper mapper;

        public ProjectStatusRepository(ETrackingContext context)
        {
            this.context = context;
        }

        public void Create(ProjectStatus status)
        {
            context.ProjectStatus.Add(status);
            Save();
        }

        public void Delete(int id)
        {
            var obj = context.Projects.Find(id);
            context.Projects.Remove(obj);
            Save();
        }

        public IList<ProjectStatus> GetAll()
        {
            return context.ProjectStatus.AsNoTracking().ToList<ProjectStatus>();
        }

        public ProjectStatus GetById(int id)
        {
            return context.ProjectStatus.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(ProjectStatus major)
        {
            context.Entry(major).State = EntityState.Modified;
            Save();
        }
    }
}
