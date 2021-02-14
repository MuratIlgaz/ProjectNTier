using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOTools.DTOModels
{
    public class OrderDetailDTO
    {
        public decimal TotalPrice { get; set; }
        public short Quantity { get; set; }
    }
}
