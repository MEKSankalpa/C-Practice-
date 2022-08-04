
public class CakeNameObject{

 public CakeNameObject(string name){
    CakeName = name;
 }   
 public string CakeName{
        get;
        set;
   }
}

public interface ICake{
    void AddCakeDetails(double price);
    Statistics GetStatics();
    string CakeName{get;}
}

public class DiskCake : Cake
{
    public DiskCake(string name) : base(name)
    {
    }

    public override void AddCakeDetails(double price)
    {
        using(var writer = File.AppendText($"{CakeName}.txt")){
        writer.WriteLine(price);
        }
    }

    public override Statistics GetStatics()
    {

        var result = new Statistics();
         using(var reader = File.OpenText($"{CakeName}.txt")){
            var line = reader.ReadLine();
            while(line != null){
              var num = double.Parse(line);
              result.Add(num);
              line = reader.ReadLine();
            }
        }

        return result;
    }
}

public abstract  class Cake : CakeNameObject, ICake {
    public Cake(string name) : base(name)
    {
    }

    public abstract void AddCakeDetails(double price);

    public abstract Statistics GetStatics();
}



class InMemoryCake : Cake{

    public InMemoryCake(string cakename) : base(cakename) {
        prices = new List<double>();// CakeName  = cakename;
            
       }

    public void AddCakeDetails(int price) {

        if (price > 0 && price <= 100)
        {
            prices.Add(price);
        }
        else {
            throw new ArgumentException($"Invalid Value for {nameof(price)}");
        }
    
    }


    public override void AddCakeDetails(double price) {
        if (price > 0 && price <= 100)
        {
            prices.Add(price);
        }
        else {
            throw new ArgumentException($"Invalid Value for {nameof(price)}");
        }
    
    }

    public override Statistics GetStatics() {

        var result = new Statistics();
        foreach (var item in prices) {  
            result.Add(item);
        }
        return result;

    }

    private List<double> prices;

}