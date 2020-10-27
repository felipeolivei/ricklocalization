using System;
using System.ComponentModel.DataAnnotations;

namespace RickLocalization.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
