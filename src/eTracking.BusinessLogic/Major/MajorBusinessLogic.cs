using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Repositories;
using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.BusinessLogic
{
    public class MajorBusinessLogic : IMajorBusinessLogic
    {
        private readonly IMajorRepository majorRepository;

        public MajorBusinessLogic(IMajorRepository majorRepository)
        {
            this.majorRepository = majorRepository;
        }

        public void Create(Major major)
        {
            majorRepository.Create(major);
        }

        public bool Delete(int id)
        {
            return majorRepository.Delete(id);
        }

        public IList<Major> GetAll()
        {
            return majorRepository.GetAll();
        }

        public Major GetById(int id)
        {
            return majorRepository.GetById(id);
        }

        public void Update(Major major)
        {
            majorRepository.Update(major);
        }
    }
}
