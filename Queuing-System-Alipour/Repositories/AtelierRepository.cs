using Microsoft.EntityFrameworkCore;
using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Repositories.Base;

namespace Queuing_System_Alipour.Repositories
{
    public sealed class AtelierRepository : BaseRepository
    {
        public bool Exists(int id)
        {
            return _context.Ateliers.Any(x => x.Id == id);
        }

        public bool Exists(int id, int employeeId)
        {
            return _context.Ateliers.Any(x => x.Id == id &&
                x.EmployeeId == employeeId);
        }

        public Atelier? GetById(int id)
        {
            return _context.Ateliers.SingleOrDefault(x => x.Id == id);
        }

        public List<Atelier> GetByEmployeeId(int employeeId)
        {
            return _context.Ateliers
                .Where(x => x.EmployeeId == employeeId).ToList();
        }

        public Atelier? GetByIdAndEmployeeId(int id, int employeeId)
        {
            return _context.Ateliers.Where(x => x.EmployeeId == employeeId)
                .SingleOrDefault(x => x.Id == id);
        }

        public int GetTodayAtelierQueuesCount(int employeeId)
        {
            return _context.Ateliers.Count(x => x.EmployeeId == employeeId &&
                x.QueueCreatedAt.Date == DateTime.Today.Date && x.QueueStatus == QueueStatus.Pending);
        }

        public IQueryable<Atelier> GetByQuery(int employeeId)
        {
            return _context.Ateliers.Where(x => x.EmployeeId == employeeId);
        }

        public void Update(Atelier atelier)
        {
            _context.Ateliers.Update(atelier);
        }

        public void Delete(Atelier atelier)
        {
            _context.Ateliers.Remove(atelier);
        }

        public void Delete(int id)
        {
            _context.Ateliers.Where(x => x.Id == id)
                .ExecuteDelete();
        }
    }
}
