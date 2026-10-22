namespace BilliardTraining.Api.Domain.Exercises;

/// <summary>
/// A point in the normalized playing area: X increases to the right,
/// Y increases downward, and both coordinates range from 0 to 1 inclusive.
/// Coordinates describe the ball center; ball radius is not taken into account.
/// </summary>
public class TablePosition
{
    public double X { get; }
    public double Y { get; }

    public TablePosition(double x, double y)
    {
        if (!double.IsFinite(x) || x < 0 || x > 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(x), x, "Coordinate must be a finite number between 0 and 1.");
        }

        if (!double.IsFinite(y) || y < 0 || y > 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(y), y, "Coordinate must be a finite number between 0 and 1.");
        }

        X = x;
        Y = y;
    }
}
