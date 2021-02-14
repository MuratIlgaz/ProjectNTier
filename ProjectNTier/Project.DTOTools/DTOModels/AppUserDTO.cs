using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOTools.DTOModels
{
    public class AppUserDTO
    {
        public string UserName { get; set; }
        public AppUserRole Role { get; set; }
    }
}
