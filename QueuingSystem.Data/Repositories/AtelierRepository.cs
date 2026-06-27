using Microsoft.EntityFrameworkCore;
using QueuingSystem.Data.Repositories.Base;
using QueuingSystem.Shared.Entities;

namespace QueuingSystem.Data.Repositories
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

        public bool IsTimeSlotExists(int employeeId, DateTime start, int duration)
        {
            var end = start.AddHours(duration);

            return _context.Ateliers.Any(x =>
                x.EmployeeId == employeeId &&
                x.QueueStatus == QueueStatus.Pending &&
                start < x.QueueEndAt &&
                end > x.QueueCreatedAt);
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

        public List<Atelier> GetByDate(int employeeId, DateTime date)
        {
            return _context.Ateliers.Where(x => x.EmployeeId == employeeId &&
                x.QueueCreatedAt.Date == date.Date &&
                x.QueueStatus == QueueStatus.Pending)
                .OrderBy(x => x.QueueCreatedAt).ToList();
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

        public void Create(Atelier atelier)
        {
            _context.Ateliers.Add(atelier);
        }

        public void Update(Atelier atelier)
        {
            _context.Ateliers.Update(atelier);
        }

        public void Delete(Atelier atelier)
        {
            _context.Ateliers.Remove(atelier);
        }

        public bool Delete(int id)
        {
            return _context.Ateliers.Where(x => x.Id == id)
                .ExecuteDelete() > 0;
        }
    }
}
