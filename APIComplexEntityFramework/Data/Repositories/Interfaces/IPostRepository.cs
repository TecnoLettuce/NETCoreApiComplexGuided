using APIComplexEntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Data.Repositories
{
    public interface IPostRepository
    {
        Task<bool> CreatePostAsync(Post post);
        Task<bool> DeletePostAsync(Post post);
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<IEnumerable<Post>> GetAllPostsByUserIdAsync(int idUser);
        Task<Post> GetPostByIdAsync(int id);
        Task<bool> UpdatePostAsync(Post post);
    }
}