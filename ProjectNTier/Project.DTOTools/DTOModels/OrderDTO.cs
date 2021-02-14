using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOTools.DTOModels
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        
    }
}
