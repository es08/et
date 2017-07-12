using eTracking.Interface.Repositories;
using eTracking.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTracking.DAL.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly ETrackingContext context;
        //private readonly IMapper mapper;

        public PositionRepository(ETrackingContext context)
        {
            this.context = context;
        }

        public void Create(Position project)
        {
            context.Positions.Add(project);
            Save();
        }

        public void Delete(int id)
        {
            var obj = context.Positions.Find(id);
            context.Positions.Remove(obj);
            Save();
        }

        public IList<Position> GetAll()
        {
            return context.Positions.AsNoTracking().ToList<Position>();
        }

        public Position GetById(int id)
        {
            return context.Positions.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Position position)
        {
            context.Entry(position).State = EntityState.Modified;
            Save();
        }
    }
}
