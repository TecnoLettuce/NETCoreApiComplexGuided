using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<Post>> GetAllPostAsync()
        {
            return await _postRepository.GetAllPostsAsync();
        }


        public async Task<Post> GetPostByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return await _postRepository.GetPostByIdAsync(id);

            return null;
        }

        public async Task<bool> DeletePostAsync(Post post)
        {
            return await _postRepository.DeletePostAsync(post);
        }

        public async Task<bool> CreatePostAsync(Post post)
        {
            return await _postRepository.CreatePostAsync(post);
        }

        public async Task<bool> UpdatePostAsync(Post post)
        {
            return await _postRepository.UpdatePostAsync(post);
        }

        public async Task<IEnumerable<Post>> GetAllPostsByUserIdAsync(int idUser)
        {
            return await _postRepository.GetAllPostsByUserIdAsync(idUser);
        }



    }
}
