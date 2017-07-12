using eTracking.Interface.Services;
using System;
using System.Collections.Generic;
using eTracking.Interface.Repositories;
using eTracking.Interface.BusinessLogics;
using eTracking.Model;

namespace eTracking.Service
{
    public class MajorService : IMajorService
    {
        private readonly IMajorBusinessLogic majorBusinessLogic;

        public MajorService(IMajorBusinessLogic majorBusinessLogic)
        {
            this.majorBusinessLogic = majorBusinessLogic;
        }

        public void Create(Major major)
        {
            majorBusinessLogic.Create(major);
        }

        public bool Delete(int id)
        {
            return majorBusinessLogic.Delete(id);
        }

        public IList<Major> GetAll()
        {
            return majorBusinessLogic.GetAll();
        }

        public Major GetById(int id)
        {
            return majorBusinessLogic.GetById(id);
        }

        public void Update(Major major)
        {
            majorBusinessLogic.Update(major);
        }
    }
}
