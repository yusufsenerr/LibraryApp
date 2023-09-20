using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AracKiralamaOtomasyonu.Models
{
    public class EmailVerification
    {
        [Key]
        public int ID { get; set; }
        public int IDMember { get; set; }
        public System.DateTime RecordDate { get; set; }
        public System.DateTime VerificationDate { get; set; }
        public bool VerificationStatus { get; set; }
        public string Email { get; set; }
        public string VerificationMail { get; set; }
    }
}