using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AracKiralamaOtomasyonu.Models
{
    public class PasswordReset
    {
        [Key]
        public int ID { get; set; }
        public int MemberID { get; set; }
        public string EMail { get; set; }
        public bool Verification { get; set; }
        public string Url { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}