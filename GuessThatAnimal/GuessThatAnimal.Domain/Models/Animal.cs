using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatAnimal.Domain.Models
{
    public interface IAnimal
    {
        int Id { get; set; }
        string Text { get; set; }
        IList<Attribute> Attributes{ get; set; }
    }

    public class Animal: IAnimal
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IList<Attribute> Attributes { get; set; }
    }
}
