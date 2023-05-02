using marlin_challenge_back_end.Models;

namespace marlin_challenge_back_end.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task<List<PostModel>> FindAllPosts();
        Task<PostModel> FindPost(Guid id);
        Task<PostModel> CreatePost(PostModel post);
        Task<PostModel> UpdatePost(PostModel usuario, Guid id);
        Task<bool> DeletePost(Guid id);
    }
}
