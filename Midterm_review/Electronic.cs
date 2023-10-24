using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_review
{
    internal class Electronic : IShippable
    {
        public int SKU { get; }
        public string Name { get; }
        public string Description { get; }
        public int Quantity { get; set; }
        public int Weight { get; set; }

        public Electronic(int sku, string name, string desc, int quantity, int weight)
        {
            
            
            SKU = sku;
            Name = name;
            Description = desc;
            Quantity = quantity;

           
                Weight = weight; 
          
        }
        public int GetTotalDeliveryDays()
        {
            if (!ValidateShipment())
            {
                return 0;
            }
            else
            {
                return Weight < 10 ? Quantity : Quantity * 2;   
            }
        }

        public bool ValidateShipment()
        {
            if (SKU > 0 && Quantity > 0 && Weight > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Quantity}  {Name} will take {GetTotalDeliveryDays()}";
        }
    }
}
