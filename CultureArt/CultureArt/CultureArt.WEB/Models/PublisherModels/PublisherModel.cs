using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.PublisherModels
{
    public class PublisherModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen yayıncı adını giriniz.")]
        [MinLength(5, ErrorMessage = "Min 5 karakter giriniz.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Lütfen yayıncı websitesini giriniz.")]
        [MinLength(10, ErrorMessage = "Min 10 karakter giriniz.")]
        public string? WebSiteHomePageUrl { get; set; }
    }
}
