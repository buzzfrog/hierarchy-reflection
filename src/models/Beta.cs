namespace models;

public class Beta : BaseModel
{
    public string Name { get; set; } = string.Empty;

    [Children]
    public List<Gamma> Gammas { get; set; } = new List<Gamma>();
}
