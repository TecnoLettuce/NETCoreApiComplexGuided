using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.ModelDTO
{
    public class PostReaderDTO
    {
        public string ImxPost { get; set; }
        public int Rate { get; set; }

        public virtual UserReaderDTO User { get; set; }

    }
}
