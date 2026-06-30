using LSP;


Sparrow sparrow =
new Sparrow("Sparrow");


Penguin penguin =
new Penguin("Penguin");


BirdManager manager =
new BirdManager();


manager.MakeBirdFly(sparrow);


penguin.Swim();