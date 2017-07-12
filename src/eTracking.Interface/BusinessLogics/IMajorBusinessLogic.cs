using System.Collections.Generic;
using eTracking.Model;
namespace eTracking.Interface.BusinessLogics
{
    public interface IMajorBusinessLogic
    {
        IList<Major> GetAll();
        Major GetById(int id);
        void Create(Major major);
        void Update(Major major);
        bool Delete(int id);
    }
}
