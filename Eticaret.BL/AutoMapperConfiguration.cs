using AutoMapper;
using Eticaret.Dto.Kategori;
using Eticaret.Dto.Resim;
using Eticaret.Dto.Sayfa;
using Eticaret.Dto.Urun;
using Eticaret.Entity;

namespace Eticaret.BL
{
    public static class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            //MapperConfiguration config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<List<Kullanici>, List<KullaniciListDto>>();
            //    cfg.CreateMap<List<KullaniciListDto>, List<Kullanici>>();
            //    cfg.CreateMap<Kullanici, KullaniciEditDto>();
            //    cfg.CreateMap<KullaniciEditDto, Kullanici>();
            //});
            //Mapper.Initialize(cfg =>
            //    cfg.AddProfiles(new[]{
            //        typeof(Kullanici) ,
            //        typeof(KullaniciListDto),
            //        typeof(List<Kullanici>),
            //        typeof(List<KullaniciListDto>),
            //        typeof(KullaniciEditDto)
            //    })
            //);

            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<List<Kullanici>, List<KullaniciListDto>>();
                //cfg.CreateMap<List<KullaniciListDto>, List<Kullanici>>();

                cfg.CreateMap<Sayfa, SayfaListDto>();
                cfg.CreateMap<SayfaListDto, Sayfa>();
                cfg.CreateMap<Sayfa, SayfaEditDto>();
                cfg.CreateMap<SayfaEditDto, Sayfa>();
                cfg.CreateMap<Sayfa, SayfaDetailDto>();
                cfg.CreateMap<SayfaDetailDto, Sayfa>();

                cfg.CreateMap<Kategori, KategoriListDto>();
                cfg.CreateMap<KategoriListDto, Kategori>();
                cfg.CreateMap<Kategori, KategoriEditDto>();
                cfg.CreateMap<KategoriEditDto, Kategori>();
                cfg.CreateMap<Kategori, KategoriDetailDto>();
                cfg.CreateMap<KategoriDetailDto, Kategori>();

                cfg.CreateMap<Urun, UrunListDto>();
                cfg.CreateMap<UrunListDto, Urun>();
                cfg.CreateMap<Urun, UrunEditDto>();
                cfg.CreateMap<UrunEditDto, Urun>();
                cfg.CreateMap<Urun, UrunDetailDto>();
                cfg.CreateMap<UrunDetailDto, Urun>();

                cfg.CreateMap<Resim, ResimListDto>();
                cfg.CreateMap<ResimListDto, Resim>();
                cfg.CreateMap<Resim, ResimEditDto>();
                cfg.CreateMap<ResimEditDto, Resim>();
            }
            );


        }
    }
}
