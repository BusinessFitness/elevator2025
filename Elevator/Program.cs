using Elevator;

var ui = new ElevatorUI();

ui.GetCurrentFloor();
ui.RequestToGoDown(2);
ui.RequestToGoUp(2);
ui.RequestToGoToFloor(1);

ui.ExecuteCycle();
