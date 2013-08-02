using System;
using FluentNHibernate.Mapping;

namespace Migration
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
        Introduce = 2
    }

    public class PostItemMap : ClassMap<PostItem>
    {
        public PostItemMap()
        {
            Id(o => o.Id).GeneratedBy.Assigned();
            Map(o => o.Content);
            Map(o => o.Type);
            Map(o => o.Time);
        }
    }
}
