using System.Runtime.CompilerServices;

class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision { get; set; }
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }




    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight
    {
        get { return Weight; }
        set
        {
            if(value < 0){
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative");
            }
            _weight = value;
        }
    }


    
    // TODO: define the 'DisplayWeight' property
    private double displayWeight;
    public string DisplayWeight()
    {
        
        return displayWeight.ToString();
    }


    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5;

    // Method to set the precision
    //public void TareAdjustment(int val)
    //{
    //    tareAdjustment = val;
    //}
}
