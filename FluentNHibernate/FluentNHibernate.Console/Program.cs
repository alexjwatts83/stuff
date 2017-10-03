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
using FluentNHibernate.Domain.Models;

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
                    var question = new Question()
                    {
                        Text = "How much would could a wood chuck chuck?"
                    };
                    //foreach (var splitTest in splitTestSet.SplitTests)
                    //{
                    //    ////session.Save(splitTest.Weighting);
                    //    //session.Save(splitTest.FlowA);
                    //    //session.Save(splitTest.FlowB);
                    //    //session.Save(splitTest.FlowC);
                    //    //foreach (var splitTestCharacteristic in splitTest.Characteristics)
                    //    //{
                    //    //    session.Save(splitTestCharacteristic);
                    //    //}
                    //    //session.Save(splitTest);
                    //}
                    session.Save(question);

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
