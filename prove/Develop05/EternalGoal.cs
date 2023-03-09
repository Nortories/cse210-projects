class EternalGoal : Goal
{
    private int _currentCount = 0;
    public EternalGoal(string name, string discription, int value)
    :base (name, discription, value)
    {
    }
    public EternalGoal(string name, string discription, int value, int currentCount)
    :base (name, discription, value)
    {
        _currentCount = currentCount;
    }

    public override string DisplayGoal(bool save = false)
    {
        string goalString;

        if (save == true)
            {goalString = ($"{_complete} | {_name} | {_discription} | {_value} | {_currentCount}");
            return goalString;}

        goalString = ($"{_complete} | Name: {_name} | Discription: {_discription} | Value: {_value} | Has done: {_currentCount} time(s)");

        return goalString;
    }

    public override void SetTrue()
    {
        _currentCount++;
    }
    public override int GetPoints()
    {
        return _currentCount * _value;
    }
}