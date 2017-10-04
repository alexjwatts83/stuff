using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace FluentNHibernate.Console.NHIbernate.Maps
{
    public class QuestionMap: ClassMap<Domain.Models.Question>
    {
        public QuestionMap()
        {
            Id(x => x.Id, "QuestionId").GeneratedBy.Identity();
            Map(x => x.Text).Not.Nullable();

            Table("Question");
        }
    }
}
