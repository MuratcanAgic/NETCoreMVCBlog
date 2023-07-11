using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NETCoreMVCBlog.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? YorumIcerik { get; set; }

        public int KullaniciID { get; set; }

        public Kullanici? Kullanici { get; set; }

        public DateTime YorumTarihi { get; set; } = DateTime.Now;
    }
}
