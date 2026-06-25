using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Repositories.Base;

namespace Queuing_System_Alipour.Repositories
{
    public sealed class AtelierRepository : BaseRepository
    {
        public List<Atelier> GetById(int id)
        {
            return [.. _context.Ateliers.Where(x => x.EmployeeId == id)];
        }

        public void Update(Atelier atelier)
        {
            _context.Ateliers.Update(atelier);
        }

        public void Delete(Atelier atelier)
        {
            _context.Ateliers.Remove(atelier);
        }
    }
}
