using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Exam.Objective3_1
{
    // Listing 3-1 Customer and Addresses classes
    class ManagingDataIntegrity
    {
        public class Customer
        {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string Firstname { get; set; }

            [Required, MaxLength(20)]
            public string LastName { get; set; }

            [Required]
            public Address ShippingAdderss { get; set; }

            [Required]
            public Address BillingAddress { get; set; }
        }

        public class Address
        {
            public int Id { get; set; }

            [Required, MaxLength(20)]
            public string  AddressLine1 { get; set; }

            [Required, MaxLength(20)]
            public string AddressLine2 { get; set; }

            [Required, MaxLength(20)]
            public string City { get; set; }

            [RegularExpression(@"^[A-Z]")]
            public string Postcode { get; set; }
        }
    }

    // Listing 3-2 Saving a new customer to the database



    // Listing 3-3 Running manual validation
    public static class GenericValidator<T>
    {
        public static IList<ValidationResult> Validate(T entity)
        {
            var result = new List<ValidationResult>();
            var context = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, result);
            return result;
        }
    }

}
