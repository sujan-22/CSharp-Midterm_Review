﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_review
{
    internal interface IShippable
    {
        int GetTotalDeliveryDays();


        bool ValidateShipment();
    
    }
}
