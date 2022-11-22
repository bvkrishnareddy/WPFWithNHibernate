using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFWithNHibernate.Model
{
    public class Product
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Category { get; set; }
    }
}
