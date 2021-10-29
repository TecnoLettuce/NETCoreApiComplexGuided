using APIComplexEntityFramework.ModelDTO.Mapping;
using APIComplexEntityFramework.ModelDTO.Mapping.Eraser;
using APIComplexEntityFramework.ModelDTO.Mapping.WritterPU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiComplex.Test.Test.ModelDTO.Mapping
{
    public class MappingTest
    {
        AutoMapperLikeEraserProfile _likeEraserProfile = new();
        AutoMapperPostEraserProfile _postEraserProfile = new();
        AutoMapperUserEraserProfile _userEraserProfile = new();

        AutoMapperLikeReaderProfile _likeReaderProfile = new();
        AutoMapperPostReaderProfile _postReaderProfile = new();
        AutoMapperUserReaderProfile _userReaderProfile = new();

        AutoMapperLikeWritterProfile _likeWritterProfile = new();
        AutoMapperPostWritterProfile _postWritterProfile = new();
        AutoMapperUserWritterProfile _userWritterProfile = new();


        [Fact]
        public void TestMappingCtor()
        {
            Assert.NotNull(_likeEraserProfile);
            Assert.IsType<AutoMapperLikeEraserProfile>(_likeEraserProfile);

            Assert.NotNull(_postEraserProfile);
            Assert.IsType<AutoMapperPostEraserProfile>(_postEraserProfile);

            Assert.NotNull(_userEraserProfile);
            Assert.IsType<AutoMapperUserEraserProfile>(_userEraserProfile);


            Assert.NotNull(_likeReaderProfile);
            Assert.IsType<AutoMapperLikeReaderProfile>(_likeReaderProfile);

            Assert.NotNull(_postReaderProfile);
            Assert.IsType<AutoMapperPostReaderProfile>(_postReaderProfile);

            Assert.NotNull(_userReaderProfile);
            Assert.IsType<AutoMapperUserReaderProfile>(_userReaderProfile);


            Assert.NotNull(_likeWritterProfile);
            Assert.IsType<AutoMapperLikeWritterProfile>(_likeWritterProfile);

            Assert.NotNull(_postWritterProfile);
            Assert.IsType<AutoMapperPostWritterProfile>(_postWritterProfile);

            Assert.NotNull(_userWritterProfile);
            Assert.IsType<AutoMapperUserWritterProfile>(_userWritterProfile);


        }
    }
}
