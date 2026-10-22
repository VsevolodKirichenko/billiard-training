namespace BilliardTraining.Api.Domain.Exercises;

public class BallLayout
{
    public IReadOnlyList<BallPlacement> Balls { get; }

    public BallLayout(IEnumerable<BallPlacement> balls)
    {
        ArgumentNullException.ThrowIfNull(balls);

        var placements = balls.ToArray();

        if (placements.Length == 0)
        {
            throw new ArgumentException("A layout must contain at least one ball.", nameof(balls));
        }

        if (placements.Any(ball => ball is null))
        {
            throw new ArgumentException("A layout cannot contain null balls.", nameof(balls));
        }

        if (placements.Count(ball => ball.Role == BallRole.Cue) > 1)
        {
            throw new ArgumentException("A layout cannot contain more than one cue ball.", nameof(balls));
        }

        Balls = Array.AsReadOnly(placements);
    }
}
