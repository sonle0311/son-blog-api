using SonBlog.Core.Repositories;

namespace SonBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        Task<int> CompleteAsync();
    }
}
