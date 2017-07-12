using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Repositories
{
    public interface IProjectRepository
    {
        IList<Project> GetAll();
        Project GetById(int id);
        void Create(Project project);
        void Update(Project project);
        bool Delete(int id);
        void Save();
        IList<WorkFlow> GetWorkFlows();
        WorkFlow GetWorkFlowById(int id);
        void CreateWorkFlow(WorkFlow workflow);
        void UpdateWorkFlow(WorkFlow workflow);
        bool DeleteWorkFlow(int id);
    }
}
