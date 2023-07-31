using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.PublisherEventDtos
{
    public class PublisherEventUpdateDto:PublisherEventMatchDto
    {
        public int EventId { get; set; }
    }
}
