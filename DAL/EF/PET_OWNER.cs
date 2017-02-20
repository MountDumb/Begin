namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_OWNER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET_OWNER()
        {
            PET = new HashSet<PET>();
        }

        [Key]
        public int OwnerId { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerFirstName { get; set; }

        [StringLength(50)]
        public string OwnerPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerEMail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET> PET { get; set; }
    }
}
