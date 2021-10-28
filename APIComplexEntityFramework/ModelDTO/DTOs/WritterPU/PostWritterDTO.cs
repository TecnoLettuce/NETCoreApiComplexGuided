using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO.Writter
{
    public class PostWritterDTO
    {
        public int PostId { get; set; }
        public string ImxPost { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
    }
}
