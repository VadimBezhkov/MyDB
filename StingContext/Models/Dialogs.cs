namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dialogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dialogs()
        {
            Messages = new HashSet<Messages>();
            UsersDialog = new HashSet<UsersDialog>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime TimeCreation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersDialog> UsersDialog { get; set; }
    }
}
