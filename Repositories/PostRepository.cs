using marlin_challenge_back_end.Data;
using marlin_challenge_back_end.Models;
using marlin_challenge_back_end.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace marlin_challenge_back_end.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly MarlinDbContext _dbContext;

        public PostRepository(MarlinDbContext marlinDbContext) {
            _dbContext = marlinDbContext;
        }

        public async Task<PostModel> FindPost(Guid id) {
            PostModel post = await _dbContext.Posts.FirstOrDefaultAsync(x => x.Id == id);
            return post == null ? throw  new Exception("Post not found") : post;
        }

        public async Task<List<PostModel>> FindAllPosts() {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<PostModel> CreatePost(PostModel post)
        {
            await  _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }

        public async Task<PostModel> UpdatePost(PostModel post, Guid id) {
            PostModel postCurrent = await FindPost(id) ?? throw new Exception("Post not found");
            postCurrent.Title = post.Title;
            postCurrent.Body = post.Body;

            _dbContext.Posts.Update(postCurrent);
            await _dbContext.SaveChangesAsync();
            
            return postCurrent;
        }

        public async Task<bool> DeletePost(Guid id) {
            PostModel postModel = await FindPost(id) ?? throw new Exception("Post not found");
            _dbContext.Posts.Remove(postModel);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
