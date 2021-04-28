namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Friends
    {
        public int ID { get; set; }

        public int UserID1 { get; set; }

        public int UserID2 { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
