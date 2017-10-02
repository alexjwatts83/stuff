using FluentNHibernate.Mapping;
using GuessThatAnimal.Web.Models;

namespace GuessThatAnimal.Web.NHibernate.Maps
{
    public class AnimalMap : ClassMap<Animal>
    {
        public AnimalMap()
        {
            Id(x => x.Id);
            Map(x => x.Text);
            HasMany<Models.Attribute>(x => x.Attributes).Cascade.All();
            Table("Animal");
        }
    }
}