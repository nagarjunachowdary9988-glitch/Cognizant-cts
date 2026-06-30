using Generics;


Box<int> numberBox = new Box<int>();

numberBox.SetValue(100);


Console.WriteLine(
    "Integer value: " + numberBox.GetValue()
);



Box<string> nameBox = new Box<string>();

nameBox.SetValue("Nagarjuna");


Console.WriteLine(
    "String value: " + nameBox.GetValue()
);