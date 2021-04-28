namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersDialog")]
    public partial class UsersDialog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DialogID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime TimeCreation { get; set; }

        public virtual Dialogs Dialogs { get; set; }

        public virtual Users Users { get; set; }
    }
}
