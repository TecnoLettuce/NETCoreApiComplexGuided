using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(Post post);
        Task<bool> DeletePostAsync(Post post);
        Task<IEnumerable<Post>> GetAllPostAsync();
        Task<IEnumerable<Post>> GetAllPostsByUserIdAsync(int idUser);
        Task<Post> GetPostByIdAsync(int id);
        Task<bool> UpdatePostAsync(Post post);
    }
}