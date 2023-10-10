using AutoMapper;
using SonBlog.Core.Repositories;
using SonBlog.Core.SeedWorks;
using SonBlog.Data.Repositories;

namespace SonBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SonBlogContext _context;

        public UnitOfWork(SonBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }
        public IPostRepository Posts { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
