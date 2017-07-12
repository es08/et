using eTracking.Interface.BusinessLogics;
using eTracking.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using eTracking.Model;

namespace eTracking.Service
{
    public class PositionService : IPositionService
    {
        private readonly IPositionBusinessLogic positionBusinessLogic;

        public PositionService(IPositionBusinessLogic positionBusinessLogic)
        {
            this.positionBusinessLogic = positionBusinessLogic;
        }

        public void Create(Position position)
        {
            positionBusinessLogic.Create(position);
        }

        public void Delete(int id)
        {
            positionBusinessLogic.Delete(id);
        }

        public IList<Position> GetAll()
        {
            return positionBusinessLogic.GetAll();
        }

        public Position GetById(int id)
        {
            return positionBusinessLogic.GetById(id);
        }

        public void Update(Position position)
        {
            positionBusinessLogic.Update(position);
        }
    }
}
