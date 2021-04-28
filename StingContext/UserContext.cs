using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyDB
{
    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Avatars> Avatars { get; set; }
        public virtual DbSet<Dialogs> Dialogs { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<LikeAvatar> LikeAvatar { get; set; }
        public virtual DbSet<LikePhoto> LikePhoto { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersDialog> UsersDialog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>()
                .HasMany(e => e.Photos)
                .WithRequired(e => e.Albums)
                .HasForeignKey(e => e.AlbumID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avatars>()
                .HasMany(e => e.LikeAvatar)
                .WithRequired(e => e.Avatars)
                .HasForeignKey(e => e.AvatarID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avatars>()
                .HasMany(e => e.Messages)
                .WithMany(e => e.Avatars)
                .Map(m => m.ToTable("MessageAvatar").MapLeftKey("AvatarID").MapRightKey("MessageID"));

            modelBuilder.Entity<Dialogs>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Dialogs)
                .HasForeignKey(e => e.DialogID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dialogs>()
                .HasMany(e => e.UsersDialog)
                .WithRequired(e => e.Dialogs)
                .HasForeignKey(e => e.DialogID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Messages>()
                .HasMany(e => e.Photos)
                .WithMany(e => e.Messages)
                .Map(m => m.ToTable("PhotoMessage").MapLeftKey("MessageID").MapRightKey("PhotoID"));

            modelBuilder.Entity<Photos>()
                .HasMany(e => e.LikePhoto)
                .WithRequired(e => e.Photos)
                .HasForeignKey(e => e.PhotoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Albums)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Avatars)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Friends)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Friends1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.UserID2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LikeAvatar)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.LikePhoto)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UsersDialog)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
