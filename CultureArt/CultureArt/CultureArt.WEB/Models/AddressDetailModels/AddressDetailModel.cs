using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.AddressDetailModels
{
    public class AddressDetailModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Etkinlik alanı adını giriniz.")]
        [MinLength(10, ErrorMessage = "Min 10 karakter giriniz.")]
        public string? EventAreaName { get; set; }
        [Required(ErrorMessage = "Lütfen adres bilgisini giriniz.")]
        [MinLength(30, ErrorMessage = "Min 30 karakter giriniz.")]
        public string? StreetAddress { get; set; }
        public int PostCode { get; set; }
        [Range(1, 81, ErrorMessage = "Şehir bilgisi seçilememiştir.")]
        public int CityId { get; set; }
    }
}
