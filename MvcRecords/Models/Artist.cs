﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcRecords.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        [Display(Name = "Wykonawca")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        //[RegularExpression("[a-zA-Z]{2,}", ErrorMessage = "Nazwa kraju nie może zawierać cyfr")]
        [Display(Name = "Kraj pochodzenia")]
        public string Country { get; set; }
    }
}