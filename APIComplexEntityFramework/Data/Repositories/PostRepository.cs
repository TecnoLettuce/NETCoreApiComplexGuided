using APIComplexEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly ApiContext _context;
        public PostRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _context.Post
                .Include(i => i.User)
                .ToArrayAsync();
        }

        // Este no funciona
        public async Task<IEnumerable<Post>> GetAllPostsByUserIdAsync(int idUser)
        {
            return await _context.Post.Include(i => i.User).Where(w => w.User.UserId == idUser).ToArrayAsync();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await _context.Post
                .Include(i => i.User)
                .FirstOrDefaultAsync(w => w.PostId == id);
        }

        public async Task<bool> DeletePostAsync(Post post)
        {
            bool result = _context.Post.Remove(post) != null;
            if (result)
                await _context.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreatePostAsync(Post post)
        {
            bool result = await _context.Post.AddAsync(post) != null;

            if (result)
                await _context.SaveChangesAsync();

            return result;

        }

        public async Task<bool> UpdatePostAsync(Post post)
        {

            var postExtracted = await _context.Post.FirstOrDefaultAsync(f => f.PostId == post.PostId);

            if (postExtracted != null)
            {
                postExtracted.ImxPost = post.ImxPost;
                postExtracted.User = post.User;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

    }
}
