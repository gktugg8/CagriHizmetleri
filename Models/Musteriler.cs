using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CagriHizmetleri.Models
{
    public class Musteriler
    {
        [Key]
        public int ID { get; set; }
       
        public string Ad { get; set; }
       
        public string Soyad { get; set; }
       
        public string Mail { get; set; }
        
        public int Telefon { get; set; }
       
        public string Sorun { get; set; }

       

        public IList<CagriOperatorleri> CagriOperatorleris { get; set; }
    }
}
