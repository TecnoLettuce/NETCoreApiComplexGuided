﻿namespace APIComplexEntityFramework.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
    }
}
