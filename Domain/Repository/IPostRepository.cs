using Domain.Entities;
using Domain.ValueObject;

namespace Domain.Repository
{
    public interface IPostRepository
    {
        Task CreatePost(Post post);
        Task<Post> GetPostById(Guid id);
        Task<List<Post>> GetAllPosts();
        Task AddTagToPost(Guid postId, Tag tag);
    }
}
