//shopping cart items list
List<string> cart = new List<string>();
//shopping cart price list
List<decimal> price = new List<decimal>();
//items available list
Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
  { "apple", 0.99m} ,
  { "banana", 0.59m},
  { "califlower", 1.59m},
  { "dragonfruit", 2.19m},
  { "elderberry", 1.79m},
  { "figs", 2.09m},
  { "grapefruit", 1.99m},
  { "honeydew", 3.49m},
};
//menu/items
Console.WriteLine("Welcome to Josh's Market!");
Console.Write("Item\t\t\tPrice\n");
Console.WriteLine("");
Console.WriteLine("=============================\n" +
     "apple\t\t\t$0.99\n" +
     "banana\t\t\t$0.59\n" +
     "cauliflower\t\t$1.59\n" +
     "dragonfruit\t\t$2.19\n" +
     "elderberry\t\t$1.79\n" +
     "figs\t\t\t$2.09\n" +
     "grapefruit\t\t$1.99\n" +
     "honeydew\t\t$3.49\n");

//questions loop
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please choose an item");
    string choice = Console.ReadLine().ToLower();

    if (menu.ContainsKey(choice))
    {
        cart.Add(choice);
        price.Add(menu[choice]);
        Console.WriteLine($"You have added {choice} for "  + menu[choice]);
        runProgram = true;
    }
    else
    {
        Console.WriteLine("Please choose again");
        Console.Write("Item\t\t\tPrice\n");
        Console.WriteLine("");
        Console.WriteLine("=============================\n" +
             "apple\t\t\t$0.99\n" +
             "banana\t\t\t$0.59\n" +
             "cauliflower\t\t$1.59\n" +
             "dragonfruit\t\t$2.19\n" +
             "elderberry\t\t$1.79\n" +
             "figs\t\t\t$2.09\n" +
             "grapefruit\t\t$1.99\n" +
             "honeydew\t\t$3.49\n");
    }
    Console.WriteLine("Would you like to continue shopping? y/n");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "yes")
            {
                Console.Write("Item\t\t\tPrice\n");
                Console.WriteLine("");
                Console.WriteLine("(\"=============================\n" +
                     "apple\t\t\t$0.99\n" +
                     "banana\t\t\t$0.59\n" +
                     "cauliflower\t\t$1.59\n" +
                     "dragonfruit\t\t$2.19\n" +
                     "elderberry\t\t$1.79\n" +
                     "figs\t\t\t$2.09\n" +
                     "grapefruit\t\t$1.99\n" +
                     "honeydew\t\t$3.49\n");
            }
            else if (answer == "n" || answer == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine($"{answer} is not valid");                               
            } 
}
//closing roundup of items and costs (receipt)
Console.WriteLine("Thanks for your order!\r\nHere's what you got:\r\n");
Console.WriteLine("======ORDER TOTAL=======");
Console.WriteLine("=========================\n");
Console.WriteLine("Item\t\t\tPrice\n");
Console.WriteLine("=============================\n");
//list each item
foreach (string e in cart)
{
    Console.Write($"{e} \t\t\t${menu[e]}\n");
}
//shopping stats
decimal total = price.Sum();
decimal maxE = price.Max();
decimal lowE = price.Min();
decimal average = price.Average();

Console.WriteLine($"Total\t\t\t${total}\n");
Console.WriteLine($"Your most expensive item was ${maxE}");
Console.WriteLine($"Your cheapest item was ${lowE}");
Console.WriteLine($"The average cost per item was ${average}");

Console.WriteLine("Come in Again!");