using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AracKiralamaOtomasyonu.Models.Context;

namespace AracKiralamaOtomasyonu.Models
{
    public class Recipient
    {
        [Key]
        public int ID { get; set; }
        public int IDMember { get; set; }
        public bool Durum { get; set; }

        public Books books { get; set; }

    }
}