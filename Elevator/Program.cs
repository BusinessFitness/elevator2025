using Elevator;

var ui = new ElevatorUI();

ui.GetCurrentFloor();
ui.RequestToGoUp(2);
ui.RequestToGoToFloor(3);
ui.RequestToGoDown(3);

RunElevatorCycles(ui);
return;

static void RunElevatorCycles(ElevatorUI elevatorUi)
{
    const int numberOfCycles = 10;
    for (var i = 0; i < numberOfCycles; i++)
        elevatorUi.ExecuteCycle();
}