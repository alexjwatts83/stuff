using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuessThatAnimal.Web.Models
{
    public class Attribute
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
        public virtual Question Question { get; set; }
    }
}