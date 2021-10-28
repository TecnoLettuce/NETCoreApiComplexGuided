using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Writter
{
    public class LikeWritterDTO
    {
        public int LikeId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
