using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.Interface.BusinessLogics
{
    public interface IPositionBusinessLogic
    {
        IList<Position> GetAll();
        Position GetById(int id);
        void Create(Position positiion);
        void Update(Position positiion);
        void Delete(int id);
    }
}
