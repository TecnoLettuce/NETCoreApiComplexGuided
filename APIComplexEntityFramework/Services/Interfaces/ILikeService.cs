using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface ILikeService
    {
        Task<bool> CreateLikeAsync(LikeWritterDTO like);
        Task<bool> DeleteLikeAsync(LikeEraserDTO like);
        Task<IEnumerable<LikeReaderDTO>> GetAllLikesAsync();
        Task<IEnumerable<LikeReaderDTO>> GetAllLikesByPostIdAsync(int postId);
        Task<IEnumerable<LikeReaderDTO>> GetAllLikesByUserIdAsync(int userId);
        Task<LikeReaderDTO> GetLikeByIdAsync(int LikeId);
        Task<bool> UpdateLikeAsync(LikeWritterDTO like);
    }
}