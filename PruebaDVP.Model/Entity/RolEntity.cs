namespace PruebaDVP.Model.Entity;

public partial class RolEntity
{
    public int IdRol { get; set; }

    public int IdUser { get; set; }

    public string NameRol { get; set; } = null!;

    public virtual UserEntity IdUserNavigation { get; set; } = null!;
}
