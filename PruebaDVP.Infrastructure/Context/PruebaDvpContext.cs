using Microsoft.EntityFrameworkCore;
using PruebaDVP.Model.Entity;

namespace PruebaDVP.Context;

public partial class PruebaDvpContext : DbContext
{
    public PruebaDvpContext()
    {
    }

    public PruebaDvpContext(DbContextOptions<PruebaDvpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RolEntity> Rols { get; set; }

    public virtual DbSet<TaskEntity> Tasks { get; set; }

    public virtual DbSet<TaskEntity> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //   => optionsBuilder.UseSqlServer("Server=.\\LOCALHOST;Database=PruebaDVP;User Id=sa;Password=12345678;Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RolEntity>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NameRol)
                .HasMaxLength(30)
                .HasColumnName("name_rol");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Rols)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_User");
        });

        modelBuilder.Entity<TaskEntity>(entity =>
        {
            entity.HasKey(e => e.IdTask);

            entity.ToTable("Task");

            entity.Property(e => e.IdTask).HasColumnName("id_task");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("User");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Pass)
                .HasMaxLength(250)
                .HasColumnName("pass");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
