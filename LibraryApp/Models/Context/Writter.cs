using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AracKiralamaOtomasyonu.Models.Context
{
    public class Writter 
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime BirthDay { get; set; }
        public bool Gender { get; set; }
        public System.DateTime CreateDay { get; set; }
        public virtual ICollection<Books> books { get; set; }
    }
}