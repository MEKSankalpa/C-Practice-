// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to the Cake shop!");

// Cake Details
var cake = new DiskCake("Red velvate"); // creating one cake instance


//Method overloading
cake.AddCakeDetails(100);
cake.AddCakeDetails(50.5);

CreateCakeDetails(cake);




//Statics Method Calling
var statistics = cake.GetStatics(); //return an object
Console.WriteLine($"Here are the Details of  {cake.CakeName} Cake");
Console.WriteLine($"Highest Price of the Cake Price List {statistics.High}");
Console.WriteLine($"Lowest Price of the Cake Price List {statistics.Low}");
Console.WriteLine($"Average Price of the Cake Price List {statistics.Average:N2}");
Console.WriteLine($"Average Letter of the Cake Prices {statistics.AverageLetter}");



//User Details
var user = new User("Sabaragamuwa University of Sri Lanka");
user.AddUser("Keshan");
user.AddUser("Sankalpa");
user.AddUser("Madusha");

static void CreateCakeDetails(Cake cake)
{
    var close = false;
    while (!close)
    {

        try
        {
            Console.WriteLine("Please Enter a Value: You can Enter q to exit from the prompt");
            var input = Console.ReadLine();
            if (input == "q") { close = true; continue; }
            var doubleInput = double.Parse(input);


            cake.AddCakeDetails(doubleInput);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}