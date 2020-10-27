using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RickLocalization.Model
{
    [Table("BrowsingHistory")]
    public class BrowsingHistory : BaseEntity
    {
        public int DimensionFromId { get; set; }
        public virtual Dimension DimensionFrom { get; set; }
        public int DimensionToId { get; set; }
        public virtual Dimension DimensionTo { get; set; }
    }
}
