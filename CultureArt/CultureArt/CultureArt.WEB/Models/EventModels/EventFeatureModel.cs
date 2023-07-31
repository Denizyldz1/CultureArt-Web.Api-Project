using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.EventModels
{
    public class EventFeatureModel
    {
        [Required(ErrorMessage = "Lütfen etkinlik sayfa başlığını giriniz.")]
        [MinLength(10, ErrorMessage = "Min 10 karakter giriniz.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Lütfen etkinlik açıklamasını giriniz.")]
        [MinLength(50, ErrorMessage = "Min 50 karakter giriniz.")]

        public string? Description { get; set; }
        public string? EventRules { get; set; }
    }
}