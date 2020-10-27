using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RickLocalization.Model
{
    [Table("Dimension")]
    public class Dimension : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual IEnumerable<BrowsingHistory> BrowsingHistoriesFrom { get; set; }
        public virtual IEnumerable<BrowsingHistory> BrowsingHistoriesTo { get; set; }
    }
}
