Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

// Task 1
Order order1 = new Order();
order1.EnterIBANs();
order1.ShowOrder();

// Task 2
List<Price> prices = new List<Price>();
Price price1 = new Price("Toy1", "ToyStore", 100);
Price price2 = new Price("Toy2", "ToyStore", 200);
Price price3 = new Price("Toy3", "ToyStore", 300);
prices.Add(price1);
prices.Add(price2);
prices.Add(price3);
Console.Write("\nЗавдання 2.\nВведіть назву шуканого товару: ");
string searchProduct = Console.ReadLine();
bool isFound = false;
foreach (Price obj in prices)
{
    if (obj.GetProductName() == searchProduct)
    {
        Searching();
        Console.WriteLine("Об'єкт знайдено!");
        obj.ShowPrice();
        isFound = true;
        break;
    }
}
if (!isFound)
{
    Searching();
    Console.WriteLine("Товар з вказаною назвою відсутній :(");
}

void Searching()
{
    Console.Clear();
    Console.Write("Пошук триває.");
    Thread.Sleep(400);
    Console.Write(".");
    Thread.Sleep(400);
    Console.Write(".");
    Thread.Sleep(400);
    Console.Clear();
}

// Task 3
double side1, side2;
Console.Write("\nЗавдання 3.\nВведіть довжину прямокутника: ");
while (true)
{
    try
    {
        side1 = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.Write("Введіть довжину прямокутника: ");
        continue;
    }
}
Console.Write("Введіть ширину прямокутника: ");
while (true)
{
    try
    {
        side2 = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.Write("Введіть ширину прямокутника: ");
        continue;
    }
}
Rectangle rect1 = new Rectangle(side1, side2);
Console.WriteLine($"Площа прямокутника дорівнює {rect1.AreaCalculator()} кв.од.\nПериметер прямокутника сягає {rect1.PerimeterCalculator()} од.");
