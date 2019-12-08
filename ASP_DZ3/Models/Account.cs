using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP_DZ3.Models
{
    public class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Sex Sex { get; set; }
        public List<InfoSource> InfoSources { get; set; }
        public string About { get; set; }
    }

    public class AccountViewModel
    {
        [Required(ErrorMessage ="Необходимо ввести логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Необходимо ввести пароль")]
        public string Password { get; set; }
        [Required (ErrorMessage ="Выберите пол")]
        public Sex Sex { get; set; }
        public List<InfoSourceModel> InfoSources { get; set; }
        public string About { get; set; }
    }
}