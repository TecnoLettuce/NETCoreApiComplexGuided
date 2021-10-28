using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(PostWritterDTO post);
        Task<bool> DeletePostAsync(PostEraserDTO post);
        Task<IEnumerable<PostReaderDTO>> GetAllPostAsync();
        Task<IEnumerable<PostReaderDTO>> GetAllPostsByUserIdAsync(int idUser);
        Task<PostReaderDTO> GetPostByIdAsync(int id);
        Task<bool> UpdatePostAsync(PostWritterDTO post);
    }
}