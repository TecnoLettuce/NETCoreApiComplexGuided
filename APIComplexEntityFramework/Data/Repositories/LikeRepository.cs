using APIComplexEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApiContext _context;
        public LikeRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Like>> GetAllLikesAsync()
        {
            return await _context.Like.
                ToArrayAsync();
        }

        public async Task<Like> GetLikeByIdAsync(int id)
        {
            return await _context.Like
                .Where(w => w.LikeId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> DeleteLikeAsync(Like like)
        {
            bool result = _context.Like.Remove(like) != null;
            if (result)
                await _context.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateLikeAsync(Like like)
        {
            var result =  await _context.Like.AddAsync(like) != null;
            if (result)
                await _context.SaveChangesAsync();

            return result;

        }

        public async Task<bool> UpdateLikeAsync(Like like)
        {
            var likeExtracted = _context.Like
                .FirstOrDefault(fod => fod.LikeId == like.LikeId);

            if (likeExtracted != null)
            {
                likeExtracted.User = like.User;
                likeExtracted.Post = like.Post;

                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<Like>> GetLikedByUserId(int userId)
        {
            return await _context.Like
                .Include(i => i.User)
                .Include(i => i.Post)
                .Where(w => w.User.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Like>> GetLikedByPostId(int postId)
        {
            return await _context.Like
                .Include(i => i.User)
                .Include(i => i.Post)
                .Where(w => w.Post.PostId == postId)
                .ToListAsync();
        }
    }
}
