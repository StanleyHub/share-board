using System;

namespace ShareBoard.Models
{
    public class Post
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime Time { get; set; }
    }
}
