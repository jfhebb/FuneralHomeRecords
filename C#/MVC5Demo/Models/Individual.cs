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

        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name="Full Name")]
        public String FullName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public String DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public String DateOfDeath { get; set; }
        public String HealthCard { get; set; }
        public String SIN { get; set; }
        public String Birthplace { get; set; }

        public String StreetAddress { get; set; }
        public String MailingAddress { get; set; }
        public String Town { get; set; }
        public String Province { get; set; }
        [DataType(DataType.PostalCode)]
        public String PostalCode { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String AltPhoneNumber { get; set; }

        public String ContactName { get; set; }
        public String ContactStreetAddress { get; set; }
        public String ContactMailAddress { get; set; }
        public String ContactTown { get; set; }
        public String ContactProvince { get; set; }
        [DataType(DataType.PostalCode)]
        public String ContactPostalCode { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String ContactPhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String ContactAltPhoneNumber { get; set; }

        public String PrearrangementStatus { get; set; }
        public int TDCanadaTrustRef { get; set; }
        public String LifeInsuranceCo { get; set; }
        public int PolicyNumber { get; set; }

    }
}