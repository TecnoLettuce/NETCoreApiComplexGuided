using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface ILikeService
    {
        Task<bool> CreateLikeAsync(Like like);
        Task<bool> DeleteLikeAsync(Like like);
        Task<IEnumerable<Like>> GetAllLikesAsync();
        Task<IEnumerable<Like>> GetAllLikesByPostIdAsync(int postId);
        Task<IEnumerable<Like>> GetAllLikesByUserIdAsync(int userId);
        Task<Like> GetLikeByIdAsync(int LikeId);
        Task<bool> UpdateLikeAsync(Like like);
    }
}