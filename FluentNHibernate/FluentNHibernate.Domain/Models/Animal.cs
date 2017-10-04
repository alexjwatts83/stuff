using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernate.Domain.Models
{
    public class Animal
    {
        public virtual int Id { get; set; }
        public virtual string Type { get; set; }
        public virtual IList<Characteristic> Characteristics { get; set; }
    }
}
