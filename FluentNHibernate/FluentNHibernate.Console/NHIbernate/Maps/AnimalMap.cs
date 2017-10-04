using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Domain.Models;
using FluentNHibernate.Mapping;

namespace FluentNHibernate.Console.NHIbernate.Maps
{
    public class AnimalMap: ClassMap<Animal>
    {
        public AnimalMap()
        {
            Id(x => x.Id, "AnimalId").GeneratedBy.Identity();
            Map(x => x.Type).Not.Nullable();

            HasManyToMany(x => x.Characteristics);

            Table("Animal");
        }
    }
}
