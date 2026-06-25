using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Repositories.Base;

namespace Queuing_System_Alipour.Repositories
{
    public sealed class PersonnelRepository : BaseRepository
    {
        public List<Personnel> GetAll()
        {
            return [.. _context.Personnels];
        }

        public Personnel? GetById(int id)
        {
            return _context.Personnels.FirstOrDefault(x => x.Id == id);
        }

        public void CreateQueue(Personnel personnel)
        {
            _context.Personnels.Add(personnel);
        }

        public void UpdateQueue(Personnel personnel)
        {
            _context.Personnels.Update(personnel);
        }
    }
}
