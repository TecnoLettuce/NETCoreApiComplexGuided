using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public interface ILikeRepository
    {
        Task<bool> CreateLikeAsync(Like like);
        Task<bool> DeleteLikeAsync(Like like);
        Task<IEnumerable<Like>> GetAllLikesAsync();
        Task<Like> GetLikeByIdAsync(int id);
        Task<bool> UpdateLikeAsync(Like like);
        Task<IEnumerable<Like>> GetLikedByUserId(int userId);
        Task<IEnumerable<Like>> GetLikedByPostId(int postId);
    }
}