namespace BilliardTraining.Api.Domain.Exercises;

public class ExerciseStep
{
    public string Instruction { get; }

    /// <summary>
    /// An optional layout to set up before this step.
    /// Null means that this step does not specify a separate setup.
    /// </summary>
    public BallLayout? SetupLayout { get; }

    public ExerciseStep(string instruction, BallLayout? setupLayout = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(instruction);

        Instruction = instruction.Trim();
        SetupLayout = setupLayout;
    }
}
