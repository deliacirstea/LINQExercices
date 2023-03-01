internal class App
{
    internal void Run()
    {
        //1
        //var endDate = DateTime.Now.AddDays(30);
        //var annons = new {endDate, seller = "Delia Cirstea", title = "Playstation 5", description = "used", price = 5500};
        //Console.WriteLine(annons.endDate);

        //2
        // var endDate = DateTime.Now.AddDays(30);
        //var annons = new
        //{
        //    endDate = DateTime.Now.AddDays(30),
        //    seller = "Delia Cirstea",
        //    title = "Playstation 5",
        //    description = "used",
        //    price = 5500,

        //    Bids = new[]
        //    {
        //        new
        //        {
        //              bidder = "Kalle",
        //              date = new DateTime(2022,11,05),
        //              price = 2100
        //        },
        //        new
        //        {
        //             bidder = "Lisa",
        //              date = new DateTime(2022,11,06),
        //              price = 2200
        //        }
        //    }

        //};
        //Console.WriteLine($"Seller: {annons.seller}");
        //Console.WriteLine($"Product: {annons.title}");
        //Console.WriteLine($"State: {annons.description}");
        //Console.WriteLine($"Price asked: {annons.price}");
        //Console.WriteLine($"Annons valid until:{annons.endDate}\n");

        //Console.WriteLine("Bids:\n");
        //foreach (var a in annons.Bids)
        //{
        //    Console.WriteLine($"Person who bid for the product: {a.bidder}");
        //    Console.WriteLine(  $"Offers made so far: {a.price}");
        //    Console.WriteLine(  $"Date: {a.date.ToShortDateString()}\n");
        //}

        //3
        //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing ELIT. Vivamus gravida tellus eu risus accumsan, eget suscipit massa mollis.";
        //var s = text.Split(' ').Where(x =>x == x.ToUpper());
        //foreach (var x in s) {
        //    Console.WriteLine(  x);
        //}

        //4
        //string[] cities =
        //    {
        //        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
        //    };

        //var s = cities.OrderBy(x => x.Length).ThenBy(x=> x).ToList();

        //foreach (var city in s) {
        //    Console.WriteLine(city);
        //}




        List<Customer> customers = new List<Customer>()
        {
                    new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                    new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                    new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                    new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                    new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                    new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                    new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                    new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                    new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                    new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
         };

        var s = customers.Select(x => new
        {
            LastName = x.Name.Split(' ')[^1],
            //LeftToSave = x.Balance < 1000000 ? 1000000 -.x.Balace :0
            LeftToSave = 1000000 - x.Balance

        }).ToList();

        foreach (var a in s)
        {
            if (a.LeftToSave > 0)
            {
                Console.WriteLine($"{a.LastName}  has to save {a.LeftToSave} kr to become a milionaire");
            }
            else
            {
                Console.WriteLine(  $"{a.LastName} already is big G");
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
}