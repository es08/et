using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Repositories
{
    public interface IMajorRepository
    {
        IList<Major> GetAll();
        Major GetById(int id);
        void Create(Major major);
        void Update(Major major);
        bool Delete(int id);
        void Save();
    }
}
