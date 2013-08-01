using System;

namespace ShareBoard.Models
{
    public class PostItem
    {
        public virtual Guid Id { get; set; }
        public virtual string Content { get; set; }
        public virtual PostItemType Type { get; set; }
        public virtual DateTime Time { get; set; }
    }

    public enum PostItemType
    {
        Hear = 0,
        Share = 1,
        Introduce =2
    }
}
