using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Domain.Models;
using FluentNHibernate.Mapping;

namespace FluentNHibernate.Console.NHIbernate.Maps
{
    public class QuestionCharacteristicLinkMap : ClassMap<QuestionCharacteristicLink>
    {
        public QuestionCharacteristicLinkMap()
        {
            Id(x => x.Id, "QuestionCharacteristicLinkId").GeneratedBy.Identity();
            References(x => x.Question).Column("QuestionId").Cascade.All();
            References(x => x.Characteristic).Column("CharacteristicId").Cascade.All();
            Table("QuestionCharacteristicLink");
        }
    }
}
