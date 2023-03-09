class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _goalCount;
    private int _bonusPoint;
    public ChecklistGoal(string name, string discription, int value, int goalCount, int bonusPoint)
    :base (name, discription, value)
    {
        _goalCount = goalCount;
        _bonusPoint = bonusPoint;
    }
    public ChecklistGoal(string name, string discription, int value, int currentCount, int goalCount, int bonusPoint)
    :base (name, discription, value)
    {
        _currentCount = currentCount;
        _goalCount = goalCount;
        _bonusPoint = bonusPoint;
    }

    public override string DisplayGoal(bool save = false)
    {
        string goalString;

        if (_isComplete == true)
            {_complete = ("[X]");}

        if (save == true)
            {goalString = ($"{_complete} | {_name} | {_discription} | {_value} | {_currentCount} | {_goalCount} | {_bonusPoint}");
            return goalString;}

        goalString = ($"{_complete} | Name: {_name} | Discription: {_discription} | Value: {_value} | Bonus: {_bonusPoint} | -----Completed:({_currentCount}/{_goalCount})");      
        return goalString;
    }

    public override void SetTrue()
    {
        _currentCount++;
        if (_currentCount == _goalCount)
        {
            _isComplete = true;
        }
    }
    public override int GetPoints()
    {
        if (_isComplete == true)
        {
            return ((_currentCount * _value) + (_bonusPoint));
        }
        return _currentCount * _value;
    }
}