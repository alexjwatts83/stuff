using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessThatAnimal.Domain.Models;
using Attribute = GuessThatAnimal.Domain.Models.Attribute;

namespace GuessThatAnimal.UnitTests
{
    public static class TestData
    {
        public static readonly IQuestion UniqueQuestion1 = new Question()
        {
            Id = 1,
            Text = "Question Unique to animal 1"
        };

        public static readonly IQuestion UniqueQuestion2 = new Question()
        {
            Id = 2,
            Text = "Question Unique to animal 2"
        };

        public static readonly IQuestion CommonQuestion = new Question()
        {
            Id = 3,
            Text = "Question Common to animal 1 and animal 2"
        };


        public static IAttribute UniqueAttribute1 = new Domain.Models.Attribute()
        {
            Id = 1,
            Text = "Unique 1",
            Question = UniqueQuestion1
        };

        public static IAttribute UniqueAttribute2 = new Domain.Models.Attribute()
        {
            Id = 2,
            Text = "Unique 2",
            Question = UniqueQuestion2
        };

        public static IAttribute CommonAttribute = new Domain.Models.Attribute()
        {
            Id = 3,
            Text = "Common Att",
            Question = CommonQuestion
        };

        public static IAnimal Animal1 = new Animal()
        {
            Id = 1,
            Text = "Animal 1",
            Attributes = new List<IAttribute>() {UniqueAttribute1, CommonAttribute}
        };
    }
}
