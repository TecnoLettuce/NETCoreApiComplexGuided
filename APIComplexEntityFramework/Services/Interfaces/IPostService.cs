using APIComplexEntityFramework.ModelDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(PostDTO post);
        Task<bool> DeletePostAsync(PostDTO post);
        Task<IEnumerable<PostDTO>> GetAllPostAsync();
        Task<IEnumerable<PostDTO>> GetAllPostsByUserIdAsync(int idUser);
        Task<PostDTO> GetPostByIdAsync(int id);
        Task<bool> UpdatePostAsync(PostDTO post);
    }
}