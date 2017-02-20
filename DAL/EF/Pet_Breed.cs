namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pet_Breed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet_Breed()
        {
            PET = new HashSet<PET>();
        }

        [Key]
        [StringLength(50)]
        public string BreedName { get; set; }

        public decimal? MinWeight { get; set; }

        public decimal? MaxWeight { get; set; }

        public int? AverageLifeExpectancy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET> PET { get; set; }
    }
}
