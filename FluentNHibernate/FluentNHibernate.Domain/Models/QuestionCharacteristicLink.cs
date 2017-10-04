using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernate.Domain.Models
{
    public class QuestionCharacteristicLink
    {
        public virtual int Id { get; set; }
        public virtual Question Question { get; set; }
        public virtual Characteristic Characteristic { get; set; }
    }
}
