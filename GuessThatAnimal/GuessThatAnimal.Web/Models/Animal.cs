using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuessThatAnimal.Web.Models
{
    public class Animal
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
        public virtual IList<Attribute> Attributes { get; set; }
    }
}