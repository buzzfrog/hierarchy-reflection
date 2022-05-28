using models;

List<Alpha> structure = new List<Alpha>
{
    new Alpha
        {
            Name = "Alpha1",
            Betas = new List<Beta>
            {
                new Beta
                    {
                        Name = "Beta11",
                        Gammas = new List<Gamma>
                        { new Gamma { Name = "Gamma111" }, new Gamma { Name = "Gamma112" } }
                    },
                new Beta
                    {
                        Name = "Beta12",
                        Gammas = new List<Gamma>
                        { new Gamma { Name = "Gamma121" }, new Gamma { Name = "Gamma122" } }
                    }
            }
        },
    new Alpha
        {
            Name = "Alpha2",
            Betas = new List<Beta>
            {
                new Beta
                    {
                        Name = "Beta21",
                        Gammas = new List<Gamma>
                        { new Gamma { Name = "Gamma211" }, new Gamma { Name = "Gamma212" } }
                    },
                new Beta
                    {
                        Name = "Beta22",
                        Gammas = new List<Gamma>
                        { new Gamma { Name = "Gamma221" }, new Gamma { Name = "Gamma222" } }
                    }
            }
        }
};

foreach (Alpha? item in structure)
{
    Child(item);
}

static void Child(BaseModel b)
{
    (string Name, string Description, IEnumerable<BaseModel> Children) = b.Info();
    Console.WriteLine($"{Name} - [{Description}]");
    foreach (BaseModel? item in Children)
    {
        Child(item);
    }
}
