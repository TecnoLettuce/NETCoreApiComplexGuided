using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
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

        public async Task<IEnumerable<PostReaderDTO>> GetAllPostAsync()
        {
            return ConvertCollection(await _postRepository.GetAllPostsAsync());
        }


        public async Task<PostReaderDTO> GetPostByIdAsync(int id)
        {
            if (id.GetType() == Type.GetType("System.Int32"))
                return _mapper.Map<PostReaderDTO>(await _postRepository.GetPostByIdAsync(id));

            return null;
        }

        public async Task<bool> DeletePostAsync(PostEraserDTO post)
        {
            return await _postRepository.DeletePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<bool> CreatePostAsync(PostWritterDTO post)
        {
            return await _postRepository.CreatePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<bool> UpdatePostAsync(PostWritterDTO post)
        {
            return await _postRepository.UpdatePostAsync(_mapper.Map<Post>(post));
        }

        public async Task<IEnumerable<PostReaderDTO>> GetAllPostsByUserIdAsync(int idUser)
        {
            return ConvertCollection(await _postRepository.GetAllPostsByUserIdAsync(idUser));
        }

        private List<PostReaderDTO> ConvertCollection(IEnumerable<Post> collectionToConvert)
        {
            List<PostReaderDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<PostReaderDTO>(item));
            }

            return collectionToReturn;
        }


    }
}
