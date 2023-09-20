using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AracKiralamaOtomasyonu.Models.Context;

namespace AracKiralamaOtomasyonu.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string IDNumber { get; set; }
        public string Address { get; set; }
        public System.DateTime BirthDay { get; set; }
        public bool Gender { get; set; }
        public string EMail { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }   
        public bool Verification { get; set; }
        public System.DateTime CreateDay { get; set; }
        public System.DateTime LastLoginTime { get; set; }
        public virtual ICollection<Recipient> Recipient  { get; set; }

    }
}