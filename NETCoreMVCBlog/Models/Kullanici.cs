using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NETCoreMVCBlog.Models
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adı")]
        [MaxLength(30)]
        public string? KullaniciAdi { get; set; }

        [Required]
        [DisplayName("Kullanıcı Soyadı")]
        [MaxLength(30)]
        public string? KullaniciSoyadi { get; set; }
    }
}
