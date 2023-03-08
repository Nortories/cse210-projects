abstract class Goal
{
    private string _name;
    private string _discription;
    private int _value;
    private bool _isComplete = false;

    public Goal(string name, string discription, int value)
    {
        _name = name;
        _discription = discription;
        _value = value;
    }

    public virtual int GetPoints()
    {
        return _value;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }
    
    public void SetComplete()
    {
        _isComplete = true;
    }
    
}