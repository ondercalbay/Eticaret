﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Dto.Urun
{
    public class UrunListDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [Required]
        [Display(Name = "Kategori")]
        public int KategoriId { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Fiyat { get; set; }

        public int ResimYolu { get; set; }
    }
}
