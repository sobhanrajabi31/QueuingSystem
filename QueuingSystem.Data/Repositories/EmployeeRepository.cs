using QueuingSystem.Shared.Entities;
using QueuingSystem.Data.Repositories.Base;
using QueuingSystem.Shared.DTOs.Employee;

namespace QueuingSystem.Data.Repositories
{
    public sealed class EmployeeRepository : BaseRepository
    {
        public Employee? GetById(int id)
        {
            return _context.Employees.Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public Employee? GetByUsername(string username)
        {
            return _context.Employees.Where(x => x.Username == username)
                .FirstOrDefault();
        }

        public bool ExistsByUsername(string username)
        {
            return _context.Employees.Any(x => x.Username == username);
        }

        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public List<StatisticsDto> GetStatistics()
        {
            return _context.Employees
                .Select(x => new StatisticsDto
                {
                    Id = x.Id,
                    Username = x.Username,
                    AtelierCount = x.Ateliers.Count(),
                    PersonnelCount = x.Personnels.Count()
                })
                .ToList();
        }
    }
}
