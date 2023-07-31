using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            this.CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
