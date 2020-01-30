namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adress")]
    public partial class Adress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adress()
        {
            Testers = new HashSet<Tester>();
        }

        public int id { get; set; }

        [StringLength(150)]
        [Display(Name = "јдрес(”лица и дом)")]
        public string name { get; set; }

        public int? idOBlast { get; set; }

        public virtual Oblast Oblast { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tester> Testers { get; set; }
    }
}
