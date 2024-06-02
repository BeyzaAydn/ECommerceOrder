using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.OrderViewModels
{
    public  class OrderViewModel
    {
        public int? AppUserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal? Freight { get; set; }

        public int Id { get; set; }

        [Display(Name = "Alıcı Adı")]

        public string ShipName { get; set; }  //alıcı adı

        [Display(Name = "Sipariş  Adresi")]

        public string ShipAddress { get; set; }
        
      


    }
}
