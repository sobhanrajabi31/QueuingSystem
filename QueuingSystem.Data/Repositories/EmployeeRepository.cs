using QueuingSystem.Shared.Entities;
using QueuingSystem.Data.Repositories.Base;

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
    }
}
