using CultureArt.WEB.Models.PublisherModels;
using System.ComponentModel.DataAnnotations;

namespace CultureArt.WEB.Models.EventModels
{
    public class CreateEventModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Etkinlik adını giriniz.")]
        [MinLength(5, ErrorMessage = "Min 5 karakter giriniz.")]
        public string? Name { get; set; }
        [EventStartDateNotInPast(ErrorMessage = "Etkinlik başlangıç tarihi şu anki zamandan küçük olamaz.")]
        public DateTime EventStartDate { get; set; }
        [EventStartDateNotInPast(ErrorMessage = "Etkinlik bitiş tarihi şu anki zamandan küçük olamaz.")]
        public DateTime? EventEndDate { get; set; }
        [Required(ErrorMessage = "Lütfen etkinlik resim url'sini giriniz.")]
        [MinLength(5, ErrorMessage = "Min 5 karakter giriniz.")]
        public string? ImageUrl { get; set; }
        public int AddressDetailId { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public List<PublisherModel>? Publishers { get; set; }
        public EventFeatureModel? EventFeature { get; set; }
        [Display(Name = "Selected Publisher")]
        public int SelectedPublisherId { get; set; }
        public Dictionary<int, string> PublisherEventUrls { get; set; } = new Dictionary<int, string>();


    }
    public class EventStartDateNotInPastAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime inputDate = Convert.ToDateTime(value);
            DateTime currentDate = DateTime.Now;

            if (inputDate < currentDate)
            {
                return new ValidationResult("Etkinlik başlangıç tarihi şu anki zamandan küçük olamaz.");
            }

            return ValidationResult.Success;
        }
    }
}
