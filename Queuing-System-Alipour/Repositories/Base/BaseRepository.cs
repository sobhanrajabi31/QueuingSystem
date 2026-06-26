namespace Queuing_System_Alipour.Repositories.Base
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly AppDataContext _context;

        protected BaseRepository()
        {
            _context = new AppDataContext();
            //_context.Database.EnsureCreated();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
