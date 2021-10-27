using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDTO>> GetAllPostAsync()
        {
            return ConvertCollection(await _postRepository.GetAllPostsAsync());
        }


        public async Task<PostDTO> GetPostByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return _mapper.Map<PostDTO>(await _postRepository.GetPostByIdAsync(id));

            return null;
        }

        public async Task<bool> DeletePostAsync(PostDTO post)
        {
            return await _postRepository.DeletePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<bool> CreatePostAsync(PostDTO post)
        {
            return await _postRepository.CreatePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<bool> UpdatePostAsync(PostDTO post)
        {
            return await _postRepository.UpdatePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<IEnumerable<PostDTO>> GetAllPostsByUserIdAsync(int idUser)
        {
            return ConvertCollection(await _postRepository.GetAllPostsByUserIdAsync(idUser));
        }

        private List<PostDTO> ConvertCollection(IEnumerable<Post> collectionToConvert)
        {
            List<PostDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<PostDTO>(item));
            }

            return collectionToReturn;
        }


    }
}
