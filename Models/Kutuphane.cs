using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane_Projesi.Models
{
    public class Kutuphane
    {
        [Key]
        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int BaskiYili { get; set; }

    }
}
