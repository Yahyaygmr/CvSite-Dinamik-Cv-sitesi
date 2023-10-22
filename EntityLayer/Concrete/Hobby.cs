using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }
        public string HobbyDescription { get; set; }
    }
}
