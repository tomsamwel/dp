namespace CompositeDemo;

public class Product : IProduct
{
    public string Name { get; set; }
    public int Weight { get; set;  }

    public Product(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}