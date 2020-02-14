using BlogApi.Persistence.Contexts;

namespace BlogApi.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context) {
            _context = context;
        }

    }
}