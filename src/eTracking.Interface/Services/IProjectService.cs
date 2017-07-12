using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Services
{
    public interface IProjectService
    {
        IList<Project> GetAll();
        Project GetById(int id);
        void Create(Project project);
        void Update(Project project);
        bool Delete(int id);

        IList<WorkFlow> GetWorkFlows();
        WorkFlow GetWorkFlowById(int id);
        void CreateWorkFlow(WorkFlow workflow);
        void UpdateWorkFlow(WorkFlow workflow);
        bool DeleteWorkFlow(int id);
    }
}
