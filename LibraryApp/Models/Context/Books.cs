using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AracKiralamaOtomasyonu.Models.Context
{
    public class Books 
    {
        [Key]
        public int ID { get; set; }
        public Nullable<int> IDWritter { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string CoverPhoto { get; set; }
    }
}