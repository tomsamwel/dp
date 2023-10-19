using Decorator;

var armor = new Armor();

Console.WriteLine($"Default armor: ");
Console.WriteLine($"\nYou got hit with 79 damage, your armor protected you for : {79 - armor.ProtectMe(79)}\n\n");

var armorWithBlueGem = new BlueGemDecorator(armor);

Console.WriteLine($"Armor with blue gem: ");
Console.WriteLine($"\nYou got hit with 79 damage, your armor protected you for : {79 - armorWithBlueGem.ProtectMe(79)}\n\n");

var armorWithRedAndPurpleGem = new RedGemDecorator(new PurpleGemDecorator(new Armor()));

Console.WriteLine($"Armor with red and a purple gem: ");
Console.WriteLine($"\nYou got hit with 79 damage, your armor protected you for : {79 - armorWithRedAndPurpleGem.ProtectMe(79)}\n\n");

var armorWithAllGems = new BlueGemDecorator(armorWithRedAndPurpleGem);

Console.WriteLine($"Armor all gems: ");
Console.WriteLine($"\nYou got hit with 79 damage, your armor protected you for : {79 - armorWithRedAndPurpleGem.ProtectMe(79)}\n\n");