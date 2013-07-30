using System;
using FluentNHibernate.Mapping;

namespace Migration
{
    public class Post
    {
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime Time { get; set; }
    }

    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(o => o.Id).GeneratedBy.Assigned();
            Map(o => o.Title);
            Map(o => o.Text);
            Map(o => o.Time);
        }
    }
}
