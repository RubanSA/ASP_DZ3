using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_DZ3.Models
{
    public enum InfoSource
    {
        [Display(Name ="Рекомендация друзей")]
        Friends,
        [Display(Name = "Интернет")]
        Internet,
        [Display(Name = "Реклама в СМИ")]
        Promotion
    }

    public class InfoSourceModel
    {
        public InfoSource InfoSource { get; set; }
        public bool IsSelected { get; set; }
    }

}