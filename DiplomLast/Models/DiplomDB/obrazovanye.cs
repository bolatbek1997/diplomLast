namespace DiplomLast.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("obrazovanye")]
    public partial class obrazovanye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public obrazovanye()
        {
            Testers = new HashSet<Tester>();
        }

        public int id { get; set; }

        [StringLength(50)]
        [Display(Name = "Образование")]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tester> Testers { get; set; }
    }
}
