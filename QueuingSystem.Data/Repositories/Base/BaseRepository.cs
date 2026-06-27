namespace QueuingSystem.Data.Repositories.Base
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly AppDbContext _context;

        protected BaseRepository()
        {
            _context = new AppDbContext();
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
