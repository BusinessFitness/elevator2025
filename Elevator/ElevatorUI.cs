using System.ComponentModel;

namespace Elevator;

/// <summary>
/// This class should orchestrate and coordinate the objects you create, and not have any material domain logic inside of it
/// </summary>
public class ElevatorUI
{

    /// <summary>
    /// What floor is the elevator currently on?
    /// </summary>
    public int GetCurrentFloor()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// I am on the supplied floor, and wish for the elevator to go up
    /// </summary>
    public void RequestToGoUp(int currentFloor)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// I am on the supplied floor, and wish for the elevator to go down
    /// </summary>
    public void RequestToGoDown(int currentFloor)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// I am inside the elevator, and telling it to go to the nominated floor
    /// </summary>
    public void RequestToGoToFloor(int floor)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Execute one cycle of movement (eg if elevator is moving from floor 3 to 1, one cycle should move it to floor 2, the next one to floor 1
    /// </summary>
    public void ExecuteCycle()
    {
        throw new NotImplementedException();
    }

}
