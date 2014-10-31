using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CCCalc.Models
{
    public class CaclModel
    {
        public decimal numOne { get; set; }
        public decimal numTwo { get; set; }
        public decimal numRes { get; set; }
    }
}