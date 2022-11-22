using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFWithNHibernate.Model;

namespace WPFWithNHibernate.Mapping
{
    public class ProductMapping : ClassMap<Product>
    {
        public ProductMapping()
        {
            Id(x => x.ID);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Category).Not.Nullable();
            Table("Product");
        }
    }
}
