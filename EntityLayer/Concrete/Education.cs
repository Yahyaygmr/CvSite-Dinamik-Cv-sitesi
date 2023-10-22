using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string SchoolName { get; set; }
        public string Faculty { get; set; }
        public string Part { get; set; }
        public string EducationDate { get; set; }
    }
}
