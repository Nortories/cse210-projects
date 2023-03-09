abstract class Goal
{
    protected string _name;
    protected string _discription;
    protected int _value;
    private bool _isComplete = false;
    protected string _complete = ("[ ]");


    public Goal(string name, string discription, int value)
    {
        _name = name;
        _discription = discription;
        _value = value;
    }

    public virtual string DisplayGoal()
    {

        if (_isComplete == true)
            {_complete = ("[X]");}

        string goalString = ($"{_complete} | {_name} | {_discription} | {_value}");
        return goalString;
    }

    public virtual int GetPoints()
    {
        bool add = GetIsComplete();
            if ( add == true)
            {
                return _value;
            }
        return 0;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public virtual void SetTrue()
    {
        _isComplete = true;
    }
    
    public virtual string GetCount()
    {
        return "";
    }
}