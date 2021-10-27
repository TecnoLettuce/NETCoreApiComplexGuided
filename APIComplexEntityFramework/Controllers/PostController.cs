using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Models;
using APIComplexEntityFramework.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            return Ok(await _postService.GetAllPostAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostsById(int id)
        {
            return Ok(await _postService.GetPostByIdAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> CreatePost(PostDTO post)
        {
            return Ok(await _postService.CreatePostAsync(post));
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost(PostDTO post)
        {
            return Ok(await _postService.DeletePostAsync(post));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePost(PostDTO post)
        {
            return Ok(await _postService.UpdatePostAsync(post));
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetAllPostByUserId(int userId)
        {
            return Ok(await _postService.GetAllPostsByUserIdAsync(userId));
        }


    }
}
