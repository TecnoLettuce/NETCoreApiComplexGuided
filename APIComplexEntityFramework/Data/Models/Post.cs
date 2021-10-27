namespace APIComplexEntityFramework.Models
{
    public class Post
    {

        public int PostId { get; set; }
        public string ImxPost { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }

        public virtual User User { get; set; }


    }
}
