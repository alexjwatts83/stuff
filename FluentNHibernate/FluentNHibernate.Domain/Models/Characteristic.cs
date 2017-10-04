using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernate.Domain.Models
{
    public class Characteristic
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}
