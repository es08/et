using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.Services
{
    public interface IPositionService
    {
        IList<Position> GetAll();
        Position GetById(int id);
        void Create(Position position);
        void Update(Position position);
        void Delete(int id);
    }
}
