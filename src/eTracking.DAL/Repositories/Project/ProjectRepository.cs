using eTracking.Interface.Repositories;
using eTracking.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eTracking.DAL.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ETrackingContext context;
        //private readonly IMapper mapper;

        public ProjectRepository(ETrackingContext context)
        {
            this.context = context;
        }

        public void Create(Project project)
        {
            context.Projects.Add(project);
            Save();
        }

        public bool Delete(int id)
        {
            var obj = context.Projects.Find(id);
            var result = false;
            if (obj != null)
            {
                context.Projects.Remove(obj);
                Save();
                result = true;
            }

            return result;
        }

        public IList<Project> GetAll()
        {
            return context.Projects
                .Include(x => x.Creator).ThenInclude(x => x.Major)
                .Include(x => x.Creator).ThenInclude(x => x.Position)
                .Include(x => x.Status)
                .Include(x => x.ProjectStaffs).ThenInclude(x => x.Staff).ThenInclude(x => x.Major)
                .Include(x => x.ProjectStaffs).ThenInclude(x => x.Staff).ThenInclude(x => x.Position)
                .Include(x => x.Activities).ThenInclude(x => x.BorrowingType)
                .Include(x => x.Activities).ThenInclude(x => x.WorkFlows)
                .Include(x => x.Activities).ThenInclude(x => x.Activator)
                .Include(x => x.Activities).ThenInclude(x => x.Creator)
                .Include(x => x.Activities).ThenInclude(x => x.WorkFlows).ThenInclude(x => x.WorkFlow)
                .AsNoTracking().ToList<Project>();
        }

        public Project GetById(int id)
        {
            return context.Projects
                .Include(x => x.Creator).ThenInclude(x => x.Major)
                .Include(x => x.Creator).ThenInclude(x => x.Position)
                .Include(x => x.Status)
                .Include(x => x.ProjectStaffs).ThenInclude(x => x.Staff).ThenInclude(x => x.Major)
                .Include(x => x.ProjectStaffs).ThenInclude(x => x.Staff).ThenInclude(x => x.Position)
                .Include(x => x.Activities).ThenInclude(x => x.BorrowingType)
                .Include(x => x.Activities).ThenInclude(x => x.WorkFlows)
                .Include(x => x.Activities).ThenInclude(x => x.Activator)
                .Include(x => x.Activities).ThenInclude(x => x.Creator)
                .Include(x => x.Activities).ThenInclude(x => x.WorkFlows).ThenInclude(x => x.WorkFlow)
                .SingleOrDefault(x => x.ID == id);
        }

        public void Update(Project project)
        {
            context.Entry(project).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateWorkFlow(WorkFlow workflow)
        {
            context.Entry(workflow).State = EntityState.Modified;
            Save();
        }

        public IList<WorkFlow> GetWorkFlows()
        {
            return context.WorkFlows.ToList<WorkFlow>();
        }

        public void CreateWorkFlow(WorkFlow workflow)
        {
            context.WorkFlows.Add(workflow);
            Save();
        }

        public bool DeleteWorkFlow(int id)
        {
            var obj = context.WorkFlows.Find(id);
            var result = false;
            if (obj != null)
            {
                context.WorkFlows.Remove(obj);
                Save();
                result = true;
            }

            return result;
        }

        public WorkFlow GetWorkFlowById(int id)
        {
            return context.WorkFlows.Find(id);
        }
    }
}
