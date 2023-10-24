using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_review
{
    internal class Fruit : IShippable
    {
        public int SKU { get; }
        public string Name { get; }
        public string Description { get; }
        public int Quantity { get; set; }

        public Fruit(int sku, string name, string desc, int quantity)
        {
            
                SKU = sku;
            
            //if (SKU <= 0)
            //{
            //    throw new Exception("");
            //}
            //else
            //{
            //    SKU = sku;
            //}
            Name = name;
            Description = desc;
           
                Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Quantity}  {Name} will take {GetTotalDeliveryDays()}";
        }
        public int GetTotalDeliveryDays()
        {
            if (!ValidateShipment())
            {
                return 0 ;
            } else
            {
                return Quantity / 2;
            }
        }
        public bool ValidateShipment()
        {
            if(SKU > 0 && Quantity > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
