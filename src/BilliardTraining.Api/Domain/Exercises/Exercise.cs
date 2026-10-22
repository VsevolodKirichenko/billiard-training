namespace BilliardTraining.Api.Domain.Exercises;

public class Exercise
{
    public Guid Id { get; }
    public string Name { get; }
    public string? Description { get; }
    public BallLayout InitialLayout { get; }
    public IReadOnlyList<ExerciseStep> Steps { get; }

    public Exercise(
        string name,
        BallLayout initialLayout,
        IEnumerable<ExerciseStep> steps,
        string? description = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentNullException.ThrowIfNull(initialLayout);
        ArgumentNullException.ThrowIfNull(steps);

        var exerciseSteps = steps.ToArray();

        if (exerciseSteps.Length == 0)
        {
            throw new ArgumentException("An exercise must contain at least one step.", nameof(steps));
        }

        if (exerciseSteps.Any(step => step is null))
        {
            throw new ArgumentException("An exercise cannot contain null steps.", nameof(steps));
        }

        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = description?.Trim();
        InitialLayout = initialLayout;
        Steps = Array.AsReadOnly(exerciseSteps);
    }
}
