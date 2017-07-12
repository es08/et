using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Repositories;
using eTracking.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace eTracking.BusinessLogic
{
    public class ProjectBusinessLogic : IProjectBusinessLogic
    {
        private readonly IProjectRepository projectRepository;

        public ProjectBusinessLogic(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public void Create(Project project)
        {
            projectRepository.Create(project);
        }
        public bool Delete(int id)
        {
            return projectRepository.Delete(id);
        }
        public IList<Project> GetAll()
        {
            return projectRepository.GetAll();
        }
        public Project GetById(int id)
        {
            return projectRepository.GetById(id);
        }
        public void Update(Project project)
        {
            projectRepository.Update(project);
        }
        public IList<WorkFlow> GetWorkFlows()
        {
            return projectRepository.GetWorkFlows();
        }
        public WorkFlow GetWorkFlowById(int id)
        {
            return projectRepository.GetWorkFlowById(id);
        }
        public void CreateWorkFlow(WorkFlow workflow)
        {
            workflow.Created = DateTime.Now;
            workflow.Updated = DateTime.Now;
            projectRepository.CreateWorkFlow(workflow);
            UpdateTrackingSequence(workflow);
        }
        public void UpdateWorkFlow(WorkFlow workflow)
        {
            workflow.Updated = DateTime.Now;
            projectRepository.UpdateWorkFlow(workflow);
            UpdateTrackingSequence(workflow);
        }
        public bool DeleteWorkFlow(int id)
        {
            return projectRepository.DeleteWorkFlow(id);
        }

        private void UpdateTrackingSequence(WorkFlow workflow)
        {
            if (workflow != null)
            {
                var orderWorkflows = GetWorkFlows().Where(x => x.ID != workflow.ID && x.Sequence >= workflow.Sequence).OrderBy(x => x.Sequence);
                if (orderWorkflows.Any())
                {
                    var startIndex = workflow.Sequence + 1;
                    foreach (WorkFlow w in orderWorkflows)
                    {
                        w.Sequence = startIndex;
                        projectRepository.UpdateWorkFlow(w);
                        startIndex++;
                    }
                }

                var lessOrderWorkflows = GetWorkFlows().Where(x => x.ID != workflow.ID && x.Sequence <= workflow.Sequence).OrderBy(x => x.Sequence);
                if (lessOrderWorkflows.Any())
                {
                    var startIndex = 1;
                    foreach (WorkFlow w in lessOrderWorkflows)
                    {
                        if (w.Sequence == workflow.Sequence)
                            startIndex++;

                        w.Sequence = startIndex;
                        projectRepository.UpdateWorkFlow(w);
                        startIndex++;
                    }
                }

            }
        }
    }
}
