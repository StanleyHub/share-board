using System;

namespace ShareBoard.Models
{
    public class PostItem
    {
        public virtual int Id { get; set; }
        public virtual string Content { get; set; }
        public virtual PostItemType Type { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual string ImagePath { get; set; }
    }

    public enum PostItemType
    {
        Hear = 0,
        Share = 1,
        Introduce =2
    }
}
