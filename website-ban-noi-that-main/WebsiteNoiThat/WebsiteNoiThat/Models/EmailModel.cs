using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Models
{
    public class EmailModel
    {
        [DataType(DataType.EmailAddress), Display(Name = "Email người gửi")]
        [Required]
        public string ToEmail { get; set; }
        [Display(Name = "Nội dung")]
        [DataType(DataType.MultilineText)]
        public string EMailBody { get; set; }
        [Display(Name = "Tiêu đề")]
        [DataType(DataType.MultilineText)]
        public string EmailSubject { get; set; }

    }
}