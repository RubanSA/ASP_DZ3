using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_DZ3.Models
{
    public enum Sex
    {
        [Display(Name = "Мужской")]
        Male,
        [Display(Name ="Женский")]
        Female
    }
    public class SexModel
    {
        public Sex Sex { get; set; }
        public bool IsSelected { get; set; }
    }
}