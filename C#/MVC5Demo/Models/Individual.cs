using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Individual
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public String Fullname { get; set; }
        public String Spouse { get; set; }
        [DataType(DataType.Date)]
        public String DOB { get; set; }
        [DataType(DataType.Date)]
        public String DOD { get; set; }
    }
}