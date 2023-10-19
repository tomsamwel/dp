using System.Reflection.Metadata;

namespace CompositeDemo;

public class Container : IProduct
{
    private List<IProduct> Children { get; set; } = new List<IProduct>();
    public int Weight
    {
        get
        {
            int totalWeight = 0;
            foreach (IProduct child in Children)
            {
                totalWeight += child.Weight;
            }

            return totalWeight;
        }
    }

    public void Add(IProduct child)
    {
        Children.Add(child);
    }
    public void Remove(IProduct child)
    {
        Children.Remove(child);
    }
}