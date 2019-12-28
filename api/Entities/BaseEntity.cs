using System;
using System.ComponentModel.DataAnnotations;

namespace api.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            IsDeleted = false;
            CreatedDate = DateTime.UtcNow;
            UpdatedDate = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
