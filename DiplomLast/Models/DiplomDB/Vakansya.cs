namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vakansya")]
    public partial class Vakansya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vakansya()
        {
            Testers = new HashSet<Tester>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Желаемая должность")]
        public string name { get; set; }

        public int? tipVAkansya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tester> Testers { get; set; }

        public virtual TipVakansya TipVakansya1 { get; set; }
    }
}
