using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Repositories
{
    public interface IPositionRepository
    {
        IList<Position> GetAll();
        Position GetById(int id);
        void Create(Position position);
        void Update(Position position);
        void Delete(int id);
        void Save();
    }
}
