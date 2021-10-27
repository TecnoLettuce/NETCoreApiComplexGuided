using APIComplexEntityFramework.ModelDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface ILikeService
    {
        Task<bool> CreateLikeAsync(LikeDTO like);
        Task<bool> DeleteLikeAsync(LikeDTO like);
        Task<IEnumerable<LikeDTO>> GetAllLikesAsync();
        Task<IEnumerable<LikeDTO>> GetAllLikesByPostIdAsync(int postId);
        Task<IEnumerable<LikeDTO>> GetAllLikesByUserIdAsync(int userId);
        Task<LikeDTO> GetLikeByIdAsync(int LikeId);
        Task<bool> UpdateLikeAsync(LikeDTO like);
    }
}