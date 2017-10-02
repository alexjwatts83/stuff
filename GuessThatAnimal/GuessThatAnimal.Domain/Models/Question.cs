using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatAnimal.Domain.Models
{
    public interface IQuestion
    {
        int Id { get; set; }
        string Text { get; set; }
    }

    public class Question: IQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
