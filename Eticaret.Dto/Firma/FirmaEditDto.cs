using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Firma
{
    public class FirmaEditDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Adi { get; set; }

        [MaxLength(100)]
        public string LogoUrl { get; set; }

        
        [Phone]
        public string Telefon { get; set; }

        [Phone]
        public string Faks { get; set; }

        [MaxLength(200)]
        [EmailAddress]
        public string EPosta { get; set; }

        [MaxLength(200)]
        public string FaceBook { get; set; }

        [MaxLength(200)]
        public string Twitter { get; set; }

        [MaxLength(200)]
        public string Instagram { get; set; }

        [MaxLength(200)]
        public string Linkedin { get; set; }
    }
}
