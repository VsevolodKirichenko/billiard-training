namespace BilliardTraining.Api.Domain.Exercises;

/// <summary>
/// A ball's role and position in the initial layout, not its state during a shot.
/// </summary>
public class BallPlacement
{
    public BallRole Role { get; }
    public TablePosition Position { get; }

    public BallPlacement(BallRole role, TablePosition position)
    {
        if (!Enum.IsDefined(role))
        {
            throw new ArgumentOutOfRangeException(nameof(role), role, "Unknown ball role.");
        }

        ArgumentNullException.ThrowIfNull(position);

        Role = role;
        Position = position;
    }
}
