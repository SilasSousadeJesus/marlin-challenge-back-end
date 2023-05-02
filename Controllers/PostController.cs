using marlin_challenge_back_end.Models;
using marlin_challenge_back_end.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace marlin_challenge_back_end.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepositorio) {
            _postRepository = postRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PostModel>>> FindAllPost() {
            List<PostModel> posts = await _postRepository.FindAllPosts();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostModel>> findPost(Guid id)
        {
            PostModel post = await _postRepository.FindPost(id);
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<PostModel>> createPost([FromBody] PostModel post)
        {
            PostModel newPost = await _postRepository.CreatePost(post);
            return Ok(newPost);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PostModel>> UpdatePost([FromBody] PostModel post, Guid id) {
            post.Id = id;
            PostModel updatedPost = await _postRepository.UpdatePost(post, id);
            return Ok(updatedPost);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PostModel>> deletePost(Guid id) {
            bool deletedPost = await _postRepository.DeletePost(id);
            return Ok(deletedPost);
        }

    }
}
