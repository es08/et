using System;
using System.Collections.Generic;
using eTracking.Interface.Services;
using eTracking.Interface.BusinessLogics;
using eTracking.Model;

namespace eTracking.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectBusinessLogic projectBusinessLogic;

        public ProjectService(IProjectBusinessLogic projectBusinessLogic)
        {
            this.projectBusinessLogic = projectBusinessLogic;
        }

        public void Create(Project project)
        {
            projectBusinessLogic.Create(project);
        }

        public bool Delete(int id)
        {
            return projectBusinessLogic.Delete(id);
        }

        public IList<Project> GetAll()
        {
            return projectBusinessLogic.GetAll();
        }

        public Project GetById(int id)
        {
            return projectBusinessLogic.GetById(id);
        }

        public void Update(Project project)
        {
            projectBusinessLogic.Update(project);
        }

        public IList<WorkFlow> GetWorkFlows()
        {
            return projectBusinessLogic.GetWorkFlows();
        }
        public WorkFlow GetWorkFlowById(int id)
        {
            return projectBusinessLogic.GetWorkFlowById(id);
        }
        public void CreateWorkFlow(WorkFlow workflow)
        {
            projectBusinessLogic.CreateWorkFlow(workflow);
        }
        public void UpdateWorkFlow(WorkFlow workflow)
        {
            projectBusinessLogic.UpdateWorkFlow(workflow);
        }
        public bool DeleteWorkFlow(int id)
        {
            return projectBusinessLogic.DeleteWorkFlow(id);
        }
    }
}
