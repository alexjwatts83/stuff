using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace FluentNHibernate.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration();
            config.DataBaseIntegration(x =>
            {
                x.ConnectionString = "";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2012Dialect>();
            });
            config.AddAssembly(Assembly.GetExecutingAssembly());

            var sessionaFactory = config.BuildSessionFactory();

        }
    }
}
