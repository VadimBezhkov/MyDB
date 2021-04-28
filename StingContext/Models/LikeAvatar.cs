namespace MyDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LikeAvatar")]
    public partial class LikeAvatar
    {
        public int ID { get; set; }

        public int AvatarID { get; set; }

        public int UserID { get; set; }

        public bool Сondition { get; set; }

        public virtual Avatars Avatars { get; set; }

        public virtual Users Users { get; set; }
    }
}
