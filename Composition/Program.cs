RunToAction();
static string MessageFoUser()
{
    return @"Enter your Action:
(1) -> Add Product 
(2) -> Show All Products
(3) -> Calc Total Price
(4) -> Quit
Choice:";
}

static void RunToAction()
{
    Product product = new();
    int choice;
    do
    {
        Console.WriteLine(MessageFoUser());
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                product.AddProduct(product.ReadProductInfo());
                break;
            case 2:
                product.ShowAllProduct();
                break;
            case 3:
                product.ShowAllProduct();
                Console.WriteLine("-------------------");
                product.CalcTotal();
                break;
            case 4:
                return;
        }
    } while (choice >= 1 && choice <= 3);
}

public record  Product
{
    private Product(int id, string title, decimal price, string description, int stock)
    {
        Id = id;
        Title = title;
        Price = price;
        Description = description;
        Stock = stock;
    }

    public Product()
    {
        
    }
    //raed product info
    public Product ReadProductInfo()
    {
        var rnd = new Random().Next(0, 1000);

        Console.Write("Enter Product Title: ");
        var title = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        var price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter Product Description: ");
        var desc = Console.ReadLine();

        Console.Write("Enter Product Stock: ");
        var stock = Convert.ToInt32(Console.ReadLine());

        return new Product(rnd, string.IsNullOrWhiteSpace(title) ? "NULL" : title, price, string.IsNullOrWhiteSpace(desc) ? "NULL" : desc, stock);
    }

    public void AddProduct(Product product) => Products.Add(product);

    public void ShowAllProduct()
    {
        if(!CheckCart(Products))
        {
            Console.WriteLine("-------------------------------------");
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("-------------------------------------");
        }

    }

    public void CalcTotal()
    {
        if (!CheckCart(Products))
        {
            Console.WriteLine("-------------------------------------");
            decimal total = Products.Sum(p => p.Price);
            Console.WriteLine("Total: " + total.ToString("C"));
            Console.WriteLine("-------------------------------------");
        }
    }

    private bool CheckCart(List<Product> products)
    {
        if (products is null || !products.Any())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not exist any product in the cart");
            Console.ForegroundColor = ConsoleColor.Gray;
            return true;
        }
        return false;
    }
    private List<Product> Products { get;  } = new();
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
}