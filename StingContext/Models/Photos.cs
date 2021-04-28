namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Photos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photos()
        {
            LikePhoto = new HashSet<LikePhoto>();
            Messages = new HashSet<Messages>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Path { get; set; }

        public int AlbumID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TimeCreation { get; set; }

        public virtual Albums Albums { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LikePhoto> LikePhoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages { get; set; }
    }
}
