namespace models;

public class Alpha : BaseModel
{
    public string Name { get; set; } = string.Empty;

    [Children]
    public List<Beta> Betas { get; set; } = new List<Beta>();
}
