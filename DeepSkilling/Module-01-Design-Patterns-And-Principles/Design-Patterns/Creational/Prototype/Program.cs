using Prototype;


Document original =
new Document(
    "My Report",
    "Design Patterns"
);


Document copy =
(Document)original.Clone();


Console.WriteLine("Original Document:");

original.Display();


Console.WriteLine();


Console.WriteLine("Cloned Document:");

copy.Display();