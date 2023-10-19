using CompositeDemo;

var lightCase = new Product("Slowpoke Case", 20);
var heavyCase = new Product("Otterbox", 65);

// Add the phone cases to a box
var littleBox = new Container();
littleBox.Add(lightCase);
littleBox.Add(heavyCase);

// Calculate the weight of the contents of the little box
Console.WriteLine($"Weight of little box: {littleBox.Weight} grams");


// Put five little boxes in a larger bulk box
var bulkBox = new Container();
for (int i = 0; i < 75; i++)
{
    bulkBox.Add(littleBox);
}

// Calculate the weight of the contents of the bulk box
Console.WriteLine($"Weight of the bulk box: {bulkBox.Weight} grams");


// Put thirty bulk boxes in a shipping container
var shippingContainer = new Container();
for (int i = 0; i < 50; i++)
{
    shippingContainer.Add(bulkBox);
}

// Calculate the weight of the contents of the shipping container
Console.WriteLine($"Weight of the shipping container: {shippingContainer.Weight / 1000} Kg");


// Put twenty thousand shipping containers on a cargo ship
var cargoShip = new Container();
for (int i = 0; i < 20000; i++)
{
    cargoShip.Add(shippingContainer);
}

// Calculate the weight of the contents of the cargo ship
Console.WriteLine($"Weight of the cargo ship: {cargoShip.Weight / 1000 / 1000} ton");