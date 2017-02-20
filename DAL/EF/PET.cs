namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PET")]
    public partial class PET
    {
        public int PetId { get; set; }

        [Required]
        [StringLength(50)]
        public string PetName { get; set; }

        [Required]
        [StringLength(50)]
        public string PetType { get; set; }

        [Required]
        [StringLength(50)]
        public string PetBreed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PetDOB { get; set; }

        public decimal PetWeight { get; set; }

        public int? OwnerId { get; set; }

        public virtual PET_OWNER PET_OWNER { get; set; }

        public virtual Pet_Breed Pet_Breed { get; set; }
    }
}
