using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }

        public async Task<IEnumerable<Like>> GetAllLikesAsync()
        {
            return await _likeRepository.GetAllLikesAsync();
        }

        public async Task<Like> GetLikeByIdAsync(int LikeId)
        {
            return await _likeRepository.GetLikeByIdAsync(LikeId);
        }

        public async Task<IEnumerable<Like>> GetAllLikesByUserIdAsync(int userId)
        {
            return await _likeRepository.GetLikedByUserId(userId);
        }

        public async Task<IEnumerable<Like>> GetAllLikesByPostIdAsync(int postId)
        {
            return await _likeRepository.GetLikedByPostId(postId);
        }

        public async Task<bool> CreateLikeAsync(Like like)
        {
            return await _likeRepository.CreateLikeAsync(like);
        }

        public async Task<bool> DeleteLikeAsync(Like like)
        {
            return await _likeRepository.DeleteLikeAsync(like);
        }

        public async Task<bool> UpdateLikeAsync(Like like)
        {
            return await _likeRepository.UpdateLikeAsync(like);
        }




    }


}
