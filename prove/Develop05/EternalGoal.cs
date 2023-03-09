class EternalGoal : Goal
{
    private int _currentCount = 0;
    public EternalGoal(string name, string discription, int value)
    :base (name, discription, value)
    {
    }

    public override string DisplayGoal()
    {
        string goalString = ($"{_complete} | {_name} | {_discription} | {_value} | {_currentCount}");
        return goalString;
    }

    public override string GetCount()
    {
        return Convert.ToString(_currentCount);
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