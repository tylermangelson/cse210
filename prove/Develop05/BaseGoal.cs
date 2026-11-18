class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;

    // public BaseGoal(string name, string description, int points)
    // {
    //     _name = name;
    //     _description = description;
    //     _points = points;
    // }



    public BaseGoal()
    {
        GetGoalName();
        GetGoalDescription();
        GetGoalPoints();
    }

    private void GetGoalName()
    {
        Console.Write("Goal name: ");
        _name = Console.ReadLine();
    }

    private void GetGoalDescription()
    {
        Console.Write("Goal description: ");
        _description = Console.ReadLine();
    }

    private void GetGoalPoints()
    {
        Console.Write("Goal points: ");
        _points = int.Parse(Console.ReadLine());
    }

    public void LoadGoal()
    {
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine(_description);
    }

    // public string GetConsoleString()
    // {
        
    //    return $"{_name}";
    // }

    

}