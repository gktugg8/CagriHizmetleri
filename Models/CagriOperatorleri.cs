using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CagriHizmetleri.Models
{
    public class CagriOperatorleri
    {
        [Key]
        public int ID { get; set; }
        
        public string Ad{ get; set; }
       
        public string Soyad{ get; set; }

      

       

        public Musteriler musteri { get; set; }
        public int MusteriID { get; set; }





    }
}
