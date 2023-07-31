using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using System.Text.Json.Serialization;

namespace CultureArt.Core.DTOs.PublisherEventDtos
{
    public class PublisherEventDto
    {
        public int PublisherId { get; set; }
        public int EventId { get; set; }
        public string? PublisherEventUrl { get; set; }
        public Publisher? Publisher { get; set; }
        public EventDto? Event { get; set; }
    }
}
