using FluentNHibernate.Mapping;
using ShareBoard.Models;

namespace ShareBoard.Mapping
{
    public class PostItemMap : ClassMap<PostItem>
    {
        public PostItemMap()
        {
            Id(o => o.Id).GeneratedBy.Increment();
            Map(o => o.Content);
            Map(o => o.Type);
            Map(o => o.Time);
        }
    }
}
