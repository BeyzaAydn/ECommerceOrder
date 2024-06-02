using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.OrderDetailViewModels
{
    public  class OrderDetailViewModel
    {

        public int OrderId { get; set;}

        public int ProductId { get; set;}

        [Display(Name ="Ürün Adı")]

        public string ProductName { get; set;}

        [Display(Name ="Ürün adedi")]

        public int Quantity {  get; set;}

        [Display(Name = "Ürün ücreti")]
        public decimal UnitPrice {  get; set;}

        [Display(Name = "Ürün indirimi")]

        public decimal Discount { get; set; }



    }
}
