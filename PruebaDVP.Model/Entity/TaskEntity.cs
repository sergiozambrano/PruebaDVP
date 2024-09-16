namespace PruebaDVP.Model.Entity;

public partial class TaskEntity
{
    public int IdTask { get; set; }

    public int IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string State { get; set; } = null!;
}
