using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee { }

    public class EmployeeMetaData
    {
     [Required(ErrorMessage =" Enter the Name")]
     [StringLength(10,MinimumLength =5)]
        public string Name { get; set; }

        [Range(20,60)]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(20000,200000)]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
       // public string Location { get; set; }
    }
}