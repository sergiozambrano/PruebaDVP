namespace PruebaDVP.Model.Entity;

public partial class UserEntity
{
    public int IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<RolEntity> Rols { get; set; } = new List<RolEntity>();
}
