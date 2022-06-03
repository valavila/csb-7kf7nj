﻿﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DjSpot.Models
{
    public enum userType
    {
        [Display(Name = "Customer")]
        customer,
        [Display(Name = "Dj")]
        dj
    }
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }

        public string Bio { get; set; }

        public bool isDj { get; set; }
        public bool isCustomer { get; set; }
       
        [EnumDataType(typeof(userType))]
        public userType UserType { get; set; } // customer = 0, dj = 1

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }
        [DataType(DataType.Html)]
        public string SCUrl { get; set; }


    }
}
