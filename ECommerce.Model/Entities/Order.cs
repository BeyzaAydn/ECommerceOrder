using ECommerce.Model.Base;

namespace ECommerce.Model.Entities
{
    public  class Order:BaseEntity
    {
        public Order() 
        { 
            OrderDate = DateTime.Now;
        
        }

        public int ?CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal ?Freight {  get; set; }

        public string ShipName {  get; set; }  //alıcı adı

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }
        public string ?ShipRegion { get; set; }

        public string ?ShipPostalCode { get; set;}

        public string ShipCountry { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
