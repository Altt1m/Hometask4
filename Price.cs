class Price
{
    private string productName;
    private string shopName; // which contains product
    private int price; // in UAH

    public Price(string pN, string sN, int p) // Constructor with paramaters
    {
        productName = pN;
        shopName = sN;
        price = p;
    }

    public string GetProductName()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        return productName;
    }

    public void ShowPrice()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine($"Назва продукта: {productName}\nНазва магазину: {shopName}\nЦіна: {price} грн");
    }

    // Other methods
}