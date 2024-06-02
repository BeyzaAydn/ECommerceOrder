using ECommerce.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Entities
{
    public  class OrderDetail:BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice {  get; set; }
        public int Quantity {  get; set; }
        public decimal Discount { get; set; }

        public decimal TotalPrice
        {
            get
            {

                return Quantity * UnitPrice;
            }
        }

        //Mapping
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
