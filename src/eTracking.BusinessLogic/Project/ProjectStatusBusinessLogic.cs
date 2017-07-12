using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Repositories;
using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.BusinessLogic
{
    public class ProjectStatusBusinessLogic : IProjectStatusBusinessLogic
    {
        private readonly IProjectStatusRepository projectStatusRepository;

        public ProjectStatusBusinessLogic(IProjectStatusRepository projectStatusRepository)
        {
            this.projectStatusRepository = projectStatusRepository;
        }

        public void Create(ProjectStatus status)
        {
            projectStatusRepository.Create(status);
        }

        public void Delete(int id)
        {
            projectStatusRepository.Delete(id);
        }

        public IList<ProjectStatus> GetAll()
        {
            return projectStatusRepository.GetAll();
        }

        public ProjectStatus GetById(int id)
        {
            return projectStatusRepository.GetById(id);
        }

        public void Update(ProjectStatus status)
        {
            projectStatusRepository.Update(status);
        }
    }
}
