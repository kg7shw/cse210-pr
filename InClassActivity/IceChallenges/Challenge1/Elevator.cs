public class Elevator
{
    

    protected list<int> floors = new list<int>();
    private bool _elevatorState = true;
    private bool _open = false;
    private bool _closed = true;


    public string Open()
    {
        _open = true;
        if (_open == true)
        {
            return "Doors are open";
        }
    }
    public void Close()
    {
            _close = true;
        if (_close == true)
        {
            return "The doors are closed.";
        }

    }
    public string MoveFloor(string floorNum)
    {
        if (floorNum <= 30)
        {
            return $"Moving to floor {floorNum}";
        }
        else
        {
            return $"{floorNum} does not exist. Choose a floor between";
        }

    }
    
    public void PopulateFloorsList()
    {
        
    }
    public void ListFloors()
    {
        foreach (var floor in floors)
        {
            Console.WriteLine(floor);
        }
    }

    public void RequestElevator()
    {

    }

    public void Display()
    {

    }







}