using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AracKiralamaOtomasyonu.Models.Context
{
    public class Files
    {
        [Key]
        public int ID{ get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
    }
}