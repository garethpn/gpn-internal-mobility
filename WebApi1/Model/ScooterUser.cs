namespace WebApi1.Model;

public class ScooterUser
{
    public string  Name { get; }

    public int? AssignedScooterId { get; set; } = null;
    
    public ScooterUser(string name)
    {
        this.Name = name;
    }
}