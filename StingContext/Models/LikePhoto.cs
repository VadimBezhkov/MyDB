namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LikePhoto")]
    public partial class LikePhoto
    {
        public int ID { get; set; }

        public int PhotoID { get; set; }

        public int UserID { get; set; }

        public bool Сondition { get; set; }

        public virtual Users Users { get; set; }

        public virtual Photos Photos { get; set; }
    }
}
