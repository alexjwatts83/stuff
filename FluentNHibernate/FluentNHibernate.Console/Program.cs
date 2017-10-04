using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;

namespace FluentNHibernate.Console
{
    class Program
    {
        private static ISessionFactory _sessionFactory;

        static void Main(string[] args)
        {
            //creating database 
            string connectionString = ConfigurationManager.ConnectionStrings["FluentNHibernateDbSql"].ConnectionString;
            CreateDatabase(connectionString);

            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(MockData.q1);
                    session.Save(MockData.q2);
                    session.Save(MockData.q3);
                    session.Save(MockData.q4);
                    session.Save(MockData.q5);

                    session.Save(MockData.c1);
                    session.Save(MockData.c2);
                    session.Save(MockData.c3);
                    session.Save(MockData.c4);
                    session.Save(MockData.c5);

                    transaction.Commit();
                    System.Console.WriteLine("transaction committed");
                    System.Console.ReadLine();
                }
            }
        }

        static void CreateDatabase(string connectionString)
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildConfiguration();

            var exporter = new SchemaExport(configuration);
            exporter.Execute(true, true, false);

            _sessionFactory = configuration.BuildSessionFactory();
        }
    }
}
