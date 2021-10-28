using APIComplexEntityFramework.Data.Repositories;
using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
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

        public async Task<IEnumerable<LikeReaderDTO>> GetAllLikesAsync()
        {
            List<LikeReaderDTO> likeDTOsToReturn = ConvertCollection(await _likeRepository.GetAllLikesAsync());

            return likeDTOsToReturn;
        }

        public async Task<LikeReaderDTO> GetLikeByIdAsync(int LikeId)
        {
            return _mapper.Map<LikeReaderDTO>(await _likeRepository.GetLikeByIdAsync(LikeId));
        }

        public async Task<IEnumerable<LikeReaderDTO>> GetAllLikesByUserIdAsync(int userId)
        {
            List<LikeReaderDTO> likesToReturn = ConvertCollection(await _likeRepository.GetLikedByUserId(userId));

            return likesToReturn;
        }

        public async Task<IEnumerable<LikeReaderDTO>> GetAllLikesByPostIdAsync(int postId)
        {

            List<LikeReaderDTO> likesToReturn = ConvertCollection(await _likeRepository.GetLikedByPostId(postId));

            return likesToReturn;
        }

        public async Task<bool> CreateLikeAsync(LikeWritterDTO like)
        {
            return await _likeRepository.CreateLikeAsync(_mapper.Map<Like>(like));
        }

        public async Task<bool> DeleteLikeAsync(LikeEraserDTO like)
        {
            return await _likeRepository.DeleteLikeAsync(_mapper.Map<Like>(like));
        }

        public async Task<bool> UpdateLikeAsync(LikeWritterDTO like)
        {
            return await _likeRepository.UpdateLikeAsync(_mapper.Map<Like>(like));
        }

        private List<LikeReaderDTO> ConvertCollection(IEnumerable<Like> collectionToConvert)
        {
            List<LikeReaderDTO> collectionToReturn = new();

            foreach (var item in collectionToConvert)
            {
                collectionToReturn.Add(_mapper.Map<LikeReaderDTO>(item));
            }

            return collectionToReturn;
        }




    }


}
