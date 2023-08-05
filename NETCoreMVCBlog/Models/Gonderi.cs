using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NETCoreMVCBlog.Models
{
    public class Gonderi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? GonderiIcerik { get; set; }

        [Required]
        [MaxLength(30)]
        public string? GonderiBaslik { get; set; }

        public int KullaniciID { get; set; }

        public Kullanici? Kullanici { get; set; }

        public DateTime GonderiTarihi { get; set; } = DateTime.Now;

        //Gönderiye şöyle böyle eklemeler yapılmalı
    }
}
