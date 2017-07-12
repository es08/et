using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.BusinessLogics
{
    public interface IProjectStatusBusinessLogic
    {
        IList<ProjectStatus> GetAll();
        ProjectStatus GetById(int id);
        void Create(ProjectStatus status);
        void Update(ProjectStatus status);
        void Delete(int id);
    }
}
