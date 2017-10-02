using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using FluentNHibernate.Mapping;
using GuessThatAnimal.Web.Models;

namespace GuessThatAnimal.Web.NHibernate.Maps
{
    public class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {
            Id(x => x.Id);
            Map(x => x.Text);
            Table("Question");
        }
    }
}