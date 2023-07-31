using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.CategoryModels
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen kategori adını giriniz.")]
        [MinLength(3, ErrorMessage = "Min 3 karakter giriniz.")]
        public string? Name { get; set; }
    }
}
