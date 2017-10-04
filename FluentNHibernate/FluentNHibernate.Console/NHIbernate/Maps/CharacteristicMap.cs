using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace FluentNHibernate.Console.NHIbernate.Maps
{
    public class CharacteristicMap : ClassMap<Domain.Models.Characteristic>
    {
        public CharacteristicMap()
        {
            Id(x => x.Id, "CharacteristicId").GeneratedBy.Identity();
            Map(x => x.Description).Not.Nullable();

            Table("Characteristic");
        }
    }
}
