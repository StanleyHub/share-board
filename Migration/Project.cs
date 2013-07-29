using System;
using FluentNHibernate.Mapping;

namespace Migration
{
    public class Project
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }

    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(o => o.Id).GeneratedBy.Assigned();
            Map(o => o.Name);
        }
    }
}
