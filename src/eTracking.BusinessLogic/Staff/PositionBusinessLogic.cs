using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Repositories;
using eTracking.Model;
using System.Collections.Generic;

namespace eTracking.BusinessLogic
{
    public class PositionBusinessLogic : IPositionBusinessLogic
    {
        private readonly IPositionRepository positionRepository;

        public PositionBusinessLogic(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        public void Create(Position position)
        {
            positionRepository.Create(position);
        }

        public void Delete(int id)
        {
            positionRepository.Delete(id);
        }

        public IList<Position> GetAll()
        {
            return positionRepository.GetAll();
        }

        public Position GetById(int id)
        {
            return positionRepository.GetById(id);
        }

        public void Update(Position position)
        {
            positionRepository.Update(position);
        }
    }
}
