using FluentNHibernate.Mapping;
using ShareBoard.Models;

namespace ShareBoard.Mapping
{
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
