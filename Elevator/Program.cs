using Elevator;

var ui = new ElevatorUI();

ui.GetCurrentFloor();
ui.RequestToGoDown(2);
ui.RequestToGoToFloor(1);
ui.RequestToGoDown(3);
ui.ExecuteCycle();

RunElevatorCycles(ui);

void RunElevatorCycles(ElevatorUI elevatorUi)
{
    //Simple way to test elevator functionality
    const int numberOfCycles = 10;
    for (var i = 0; i < numberOfCycles; i++)
    {
        elevatorUi.ExecuteCycle();
    }
}