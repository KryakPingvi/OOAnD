namespace SpaceBattle.Lib;

public interface IRotating
{
    Angle AnglePos { get; set;} //45
    Angle RotateVelocity {get;} //90
} // AnglePos => 135

public interface ICommand
{
    public void Execute();
}

public class RotateCommand : IRotating
{
    private readonly IRotating obj;
    public RotateCommand(IRotating obj)
    {
        this.obj = obj;
    }
    public void Execute()
    {
        obj.AnglePos = obj.AnglePos + obj.AngleVelocity;
    }
}