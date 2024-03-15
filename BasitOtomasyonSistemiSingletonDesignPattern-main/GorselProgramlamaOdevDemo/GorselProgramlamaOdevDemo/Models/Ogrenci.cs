using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaOdevDemo.Models
{
    internal class Ogrenci
    {
    
        public int ogrNo {  get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string fakulte { get; set; }
        public string bolum { get; set; }
        public Ogrenci(int ogrNo, string ad, string soyad, string fakulte, string bolum)
        {
            this.ogrNo = ogrNo;
            this.ad = ad;
            this.soyad = soyad;
            this.fakulte = fakulte;
            this.bolum = bolum;
        }
    }
}
