using System.Runtime.CompilerServices;

class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision { get; set; } = 1;
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }




    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight
    {
        get { return _weight; }
        set
        {
            if(value < 0){
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative");
            }
            _weight = value;
        }
    }


    
    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        //set { _displayWeight = (_weight - TareAdjustment).ToString() + " kg"; }
        //get { return _displayWeight; }
        //return displayWeight;
        get { return (_weight - TareAdjustment).ToString($"F{Precision}") + " kg"; }
    }


    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5;
}
