public class Statistics
{
    public double High;
    public double Low;
    public double Average{
      get{
        return Sum/Count;
      }
    }
    public char AverageLetter{
        get{
             switch (Average) { 
                case var d when d >= 90.0:
                    return 'A';
                
                case var d when d >= 75.0:
                    return 'B';
            
                case var d when d >= 60.0:
                    return 'C';
            
                case var d when d >= 40.0:
                    return 'D';
         
                default:
                    return 'F';
              

          }
        }
    }

    public int Count;
    public double Sum;

    public void Add(double value){
        Count += 1;
        Sum   += value;
        Low   = Math.Min(value, Low);
        High  = Math.Max(value, High);

    }

    public Statistics()
    {
      High = double.MinValue; 
      Low  = double.MaxValue;
      Sum  = 0.0;
      Count = 0;

    }
}