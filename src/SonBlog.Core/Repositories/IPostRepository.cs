using SonBlog.Core.Domain.Content;
using SonBlog.Core.Models.Content;
using SonBlog.Core.Models;
using SonBlog.Core.SeedWorks;

namespace SonBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
