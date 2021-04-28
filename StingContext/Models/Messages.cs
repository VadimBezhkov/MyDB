namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Messages()
        {
            Avatars = new HashSet<Avatars>();
            Photos = new HashSet<Photos>();
        }

        public int ID { get; set; }

        public int DialogID { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Text { get; set; }

        public bool TextChanged { get; set; }

        public DateTime TimeCreations { get; set; }

        public virtual Dialogs Dialogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avatars> Avatars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photos> Photos { get; set; }
    }
}
