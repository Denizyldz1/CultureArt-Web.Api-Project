using CultureArt.Core.DTOs.EventDtos;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.PublisherEventDtos
{
    public class PublisherEventMatchDto
    {
        public int PublisherId { get; set; }
        public string? PublisherEventUrl { get; set; }
    }
}
