using Microsoft.EntityFrameworkCore;
using QueuingSystem.Shared.Entities;
using QueuingSystem.Data.Repositories.Base;

namespace QueuingSystem.Data.Repositories
{
    public sealed class PersonnelRepository : BaseRepository
    {
        public bool Exists(int id)
        {
            return _context.Personnels.Any(x => x.Id == id);
        }

        public Personnel? GetById(int id)
        {
            return _context.Personnels.FirstOrDefault(x => x.Id == id);
        }

        public List<Personnel> GetByDate(DateTime dateTime)
        {
            return [.. _context.Personnels.Where(x => x.QueueCreatedAt.Date == dateTime.Date)];
        }

        public void CreateQueue(Personnel personnel)
        {
            _context.Personnels.Add(personnel);
        }

        public void UpdateQueue(Personnel personnel)
        {
            _context.Personnels.Update(personnel);
        }

        public void DeleteQueue(Personnel personnel)
        {
            _context.Personnels.Remove(personnel);
        }

        public bool DeleteQueue(int id)
        {
            return _context.Personnels.Where(x => x.Id == id)
                .ExecuteDelete() > 0;
        }
    }
}
