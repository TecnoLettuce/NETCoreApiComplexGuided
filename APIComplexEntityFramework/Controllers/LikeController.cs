using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLikes()
        {
            return Ok(await _likeService.GetAllLikesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLikeById(int likeId)
        {
            return Ok(await _likeService.GetLikeByIdAsync(likeId));
        }

        [HttpGet("/Owner/{id}")]
        public async Task<IActionResult> GetLikesByUserId(int userId)
        {
            return Ok(await _likeService.GetAllLikesByUserIdAsync(userId));
        }

        [HttpGet("/Posts/{id}")]
        public async Task<IActionResult> GetLikesByPostId(int postId)
        {
            return Ok(await _likeService.GetAllLikesByPostIdAsync(postId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateLike(LikeDTO like)
        {
            return Ok(await _likeService.CreateLikeAsync(like));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLike(LikeDTO like)
        {
            return Ok(await _likeService.DeleteLikeAsync(like));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLike(LikeDTO like)
        {
            return Ok(await _likeService.UpdateLikeAsync(like));
        }

    }
}
