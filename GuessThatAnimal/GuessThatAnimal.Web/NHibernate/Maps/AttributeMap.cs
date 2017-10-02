using FluentNHibernate.Mapping;

namespace GuessThatAnimal.Web.NHibernate.Maps
{
    public class AttributeMap : ClassMap<Models.Attribute>
    {
        public AttributeMap()
        {
            Id(x => x.Id);
            Map(x => x.Text);
            References(x => x.Question);
            Table("Question");
        }
    }
}