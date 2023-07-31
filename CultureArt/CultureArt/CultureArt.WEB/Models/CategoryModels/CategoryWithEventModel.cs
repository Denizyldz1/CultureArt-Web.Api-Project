using CultureArt.WEB.Models.EventModels;

namespace CultureArt.WEB.Models.CategoryModels
{
    public class CategoryWithEventModel : CategoryModel
    {
        public EventModel? Event { get; set; }
    }
}
