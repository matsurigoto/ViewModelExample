using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModel
{
    public class CreateStudentViewModel
    {
        [DisplayName("學號")]
        [Required]
        public string ID { get; set; }

        [DisplayName("姓名")]
        public string NAME { get; set; }

        [DisplayName("地址")]
        public string ADDRESS { get; set; }

        [DisplayName("電子郵件")]
        [EmailAddress]
        public string EMAIL { get; set; }

        [DisplayName("電話")]
        [RegularExpression(@"^[0-9]*$")]
        public string TEL { get; set; }

    }
}