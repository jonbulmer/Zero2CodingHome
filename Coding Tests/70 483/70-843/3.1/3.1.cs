﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exam.Objective3_1
{
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
            public string  Addressline { get; set; }
        }
    }

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