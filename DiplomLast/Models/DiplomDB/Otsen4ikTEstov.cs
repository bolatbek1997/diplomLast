namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Otsen4ikTEstov
    {
        public int id { get; set; }

        [StringLength(60)]
        public string name { get; set; }
    }
}
