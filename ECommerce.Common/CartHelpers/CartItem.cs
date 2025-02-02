﻿namespace ECommerce.Common.CartHelpers
{
    public class CartItem
    {
        //bir sepetin ne gibi özellikleri olacaksa o değerler tanımlanacak.
        public CartItem()
        {
            Quantity = 1;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

    }
}
