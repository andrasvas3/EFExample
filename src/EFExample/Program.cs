namespace EFExample;

class Program
{
    static readonly DatabaseContext databaseContext = new();
    
    static void Main()
    {
        databaseContext.Database.EnsureDeleted();
        databaseContext.Database.EnsureCreated();

        try
        {
            databaseContext.Planets.Add(new Planet { Name = "Earth" });
            databaseContext.Planets.Add(new Planet { Name = "Mars" });
            databaseContext.Planets.Add(new Planet { Name = "Jupiter" });
            databaseContext.SaveChanges();

            databaseContext.Moons.Add(new Moon { Name = "Moon", PlanetId = 1 });
            databaseContext.Moons.Add(new Moon { Name = "Phobos", PlanetId = 2 });
            databaseContext.Moons.Add(new Moon { Name = "Deimos", PlanetId = 2 });
            databaseContext.Moons.Add(new Moon { Name = "Io", PlanetId = 3 });
            databaseContext.Moons.Add(new Moon { Name = "Europa", PlanetId = 3 });
            databaseContext.Moons.Add(new Moon { Name = "Ganymede", PlanetId = 3 });
            databaseContext.Moons.Add(new Moon { Name = "Callisto", PlanetId = 3 });
            databaseContext.SaveChanges();    
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        foreach(Moon moon in databaseContext.Moons.OrderBy(m => m.Name).ToList())
        {
            Console.WriteLine($"{moon.Id}\t{moon.Name}\t{moon.Planet!.Name}");
        }
    }
}
