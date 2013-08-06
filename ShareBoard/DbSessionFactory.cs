using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using ShareBoard.Models;

namespace ShareBoard
{
    public class DbSessionFactory
    {
        private static ISessionFactory SessionFactory { get; set; }

        public static ISessionFactory GetCurrentFactory()
        {
            return SessionFactory ?? (SessionFactory = CreateSessionFactory());
        }

        private static ISessionFactory CreateSessionFactory()
        {
            const string sqlConnectionString = "Data Source=localhost;Initial Catalog=share-board;Integrated Security=True;Enlist=false;";
            var msSqlConfiguration = MsSqlConfiguration.MsSql2008.ConnectionString(sqlConnectionString).Raw("connection.release_mode", "on_close");
            return Fluently.Configure().Database(msSqlConfiguration).Mappings(
                config => config.FluentMappings.AddFromAssembly(typeof(PostItem).Assembly)).BuildSessionFactory();
       }
    }
}