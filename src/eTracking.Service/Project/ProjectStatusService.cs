using System.Collections.Generic;
using eTracking.Interface.Services;
using eTracking.Interface.BusinessLogics;
using eTracking.Model;

namespace eTracking.Service
{
    public class ProjectStatusService : IProjectStatusService
    {
        private readonly IProjectStatusBusinessLogic projectStatusBusinessLogic;

        public ProjectStatusService(IProjectStatusBusinessLogic projectStatusBusinessLogic)
        {
            this.projectStatusBusinessLogic = projectStatusBusinessLogic;
        }

        public void Create(ProjectStatus status)
        {
            projectStatusBusinessLogic.Create(status);
        }

        public void Delete(int id)
        {
            projectStatusBusinessLogic.Delete(id);
        }

        public IList<ProjectStatus> GetAll()
        {
            return projectStatusBusinessLogic.GetAll();
        }

        public ProjectStatus GetById(int id)
        {
            return projectStatusBusinessLogic.GetById(id);
        }

        public void Update(ProjectStatus status)
        {
            projectStatusBusinessLogic.Update(status);
        }
    }
}
