namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? idOBlast { get; set; }

        public virtual Oblast Oblast { get; set; }
    }
}
