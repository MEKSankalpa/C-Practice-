public  class virtualTest
{

    
    
    public class showList  
    {
        public List<int> l;
        public showList(List<int> l){
            this.l = l;
        }

        public virtual void show(){
           for (var i = 0; i < l.Count;i++) {     
            Console.WriteLine($"Number is {l[i]}");     
           }
        }
    }

    public class FindOdd : showList
    {
        public FindOdd(List<int> l) : base(l) {

        }

        public override void show(){
            for (var i = 0; i < l.Count ;i++) {     
              if(l[i] %2 != 0){
                  Console.WriteLine($"Number is {l[i]}");
              }
           }
        }
    }


     public class FindEven : showList
    {
        public FindEven(List<int> l) : base(l) {

        }

        public override void show(){
            for (var i = 0; i < l.Count ;i++) {     
              if(l[i] %2 == 0){
                  Console.WriteLine($"Number is {l[i]}");
              }
           }
        }
    }

    static void main(){
       List<int> numbers = new  List<int>() {45,55,42,89,32,44,66};
    
       var findOdds = new FindOdd(numbers);
       findOdds.show();

       var findEvens = new FindEven(numbers);
       findEvens.show();
    }
    
}