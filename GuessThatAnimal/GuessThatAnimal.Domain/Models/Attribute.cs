using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatAnimal.Domain.Models
{
    public interface IAttribute
    {
        int Id { get; set; }
        string Text { get; set; }
        IQuestion Question { get; set; }
    }

    public class Attribute: IAttribute
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IQuestion Question { get; set; }
    }
}
