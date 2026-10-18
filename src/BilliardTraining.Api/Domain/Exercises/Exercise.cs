namespace BilliardTraining.Api.Domain.Exercises;

public class Exercise
{
    public Guid Id { get; }
    public string Name { get; }
    public string? Description { get; }

    public Exercise(string name, string? description = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = description?.Trim();
    }
}
