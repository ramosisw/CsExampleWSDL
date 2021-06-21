using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClienteWebService.Models {
    public class LoginModel {
        [Required]
        [DataType(DataType.Text)]
        public string usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}