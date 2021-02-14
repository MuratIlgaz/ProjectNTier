using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTOTools.DTOModels
{
    public class CategoryDTO
    {
        //todo:DTO sınıflarınızı acın, ilişkileri almayın sadece ID,name,description gibi anlamlı bilgileri alın
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
