namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Avatars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avatars()
        {
            LikeAvatar = new HashSet<LikeAvatar>();
            Messages = new HashSet<Messages>();
        }

        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string path { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LikeAvatar> LikeAvatar { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages { get; set; }
    }
}
