using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMk.Models
{

    [MetadataType(typeof(CustomerPartial))]
    public partial class Customer
    {
    }
    public class CustomerPartial
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage="")]

        [MinLength(4),MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1), MaxLength(100)]
        public string LastName { get; set; }
    }
}