using CompositeDemo;

namespace Testjes;

public static class CompsiteBuilder
{
    /// <summary>
    /// Creates an empty container
    /// </summary>
    /// <returns>An empty container</returns>
    public static Container CreateEmptyContainer()
    {
        return new Container();
    }
    
    /// <summary>
    ///    [c]
    ///    /
    ///   O
    /// </summary>
    /// <returns>A container with one leaf</returns>
    public static Container CreateContainerWithOneLeaves()
    {
        var c = new Container();
        var l = new Product("leaf", 1);
        c.Add(l);

        return c;
    }

    /// <summary>
    ///     [c]
    ///    /  \
    ///   O    O
    /// </summary>
    /// <returns>A container with two leafs</returns>
    public static Container CreateContainerWithTwoLeaves()
    {
        var c = new Container();
        var l = new Product("leaf", 1);
        c.Add(l);
        c.Add(l);

        return c;
    }

    /// <summary>
    ///     [c]
    ///    / | \
    ///   O  O  O
    /// </summary>
    /// <returns></returns>
    public static Container CreateContainerWithThreeLeaves()
    {
        var c = new Container();
        var l = new Product("leaf", 1);
        c.Add(l);
        c.Add(l);
        c.Add(l);

        return c;
    }

    /// <summary>
    ///        [c0]
    ///        /  \
    ///      [c1]  O
    ///      /  \
    ///     O    O
    /// </summary>
    /// <returns></returns>
    public static Container CreateContainerWithSimpleNesting()
    {
        var c0 = new Container();
        var c1 = new Container();
        var l = new Product("leaf", 1);
        
        c1.Add(l);
        c1.Add(l);
        c0.Add(c1);
        c0.Add(l);

        return c0;
    }

    /// <summary>
    ///                  [c0]
    ///                / | | \
    ///             [c1] O O  [c2]
    ///            / | \        \
    ///         [c3] O [c4]     [c5]
    ///        / | \   /  \     /  \
    ///     [c6] O  O O    O   O   [c7]
    ///     /  \                  / | | \
    ///    O    O                O  O O  O
    /// </summary>
    /// <returns></returns>
    public static Container CreateContainerWithComplexNesting()
    {
        var c0 = new Container();
        var c1 = new Container();
        var c2 = new Container();
        var c3 = new Container();
        var c4 = new Container();
        var c5 = new Container();
        var c6 = new Container();
        var c7 = new Container();

        var l = new Product("leaf", 1);
        
        // Layer 1
        c0.Add(c1);
        c0.Add(l);
        c0.Add(l);
        c0.Add(c2);
        
        // Layer 2
        c1.Add(c3);
        c1.Add(l);
        c1.Add(c4);
        
        c2.Add(c5);
        
        // Layer 3
        c3.Add(c6);
        c3.Add(l);
        c3.Add(l);
        
        c4.Add(l);
        c4.Add(l);
        
        c5.Add(l);
        c5.Add(c7);
        
        // Layer 4
        c6.Add(l);
        c6.Add(l);
        
        c7.Add(l);
        c7.Add(l);
        c7.Add(l);
        c7.Add(l);

        return c0;
    }
}