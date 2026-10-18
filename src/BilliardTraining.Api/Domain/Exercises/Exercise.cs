namespace BilliardTraining.Api.Domain.Exercises;

public class Exercise
{
    public Guid Id { get; }
    public string Name { get; }
    public string? Description { get; }
    public BallLayout InitialLayout { get; }

    public Exercise(string name, BallLayout initialLayout, string? description = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentNullException.ThrowIfNull(initialLayout);

        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = description?.Trim();
        InitialLayout = initialLayout;
    }
}
