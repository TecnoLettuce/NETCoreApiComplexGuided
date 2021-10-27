using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        public LikeService(IMapper mapper, ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LikeDTO>> GetAllLikesAsync()
        {
            List<LikeDTO> likeDTOsToReturn = ConvertCollection(await _likeRepository.GetAllLikesAsync());

            return likeDTOsToReturn;
        }

        public async Task<LikeDTO> GetLikeByIdAsync(int LikeId)
        {
            return _mapper.Map<LikeDTO>(await _likeRepository.GetLikeByIdAsync(LikeId));
        }

        public async Task<IEnumerable<LikeDTO>> GetAllLikesByUserIdAsync(int userId)
        {
            List<LikeDTO> likesToReturn = ConvertCollection(await _likeRepository.GetLikedByUserId(userId));

            return likesToReturn;
        }

        public async Task<IEnumerable<LikeDTO>> GetAllLikesByPostIdAsync(int postId)
        {

            List<LikeDTO> likesToReturn = ConvertCollection(await _likeRepository.GetLikedByPostId(postId));

            return likesToReturn;
        }

        public async Task<bool> CreateLikeAsync(LikeDTO like)
        {
            return await _likeRepository.CreateLikeAsync(_mapper.Map<Like>(like));
        }

        public async Task<bool> DeleteLikeAsync(LikeDTO like)
        {
            return await _likeRepository.DeleteLikeAsync(_mapper.Map<Like>(like));
        }

        public async Task<bool> UpdateLikeAsync(LikeDTO like)
        {
            return await _likeRepository.UpdateLikeAsync(_mapper.Map<Like>(like));
        }

        private List<LikeDTO> ConvertCollection(IEnumerable<Like> collectionToConvert)
        {
            List<LikeDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<LikeDTO>(item));
            }

            return collectionToReturn;
        }




    }


}
