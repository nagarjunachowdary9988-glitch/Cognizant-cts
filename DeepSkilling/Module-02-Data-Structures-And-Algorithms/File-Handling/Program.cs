string filePath = "sample.txt";


// Write data into file

File.WriteAllText(
    filePath,
    "Welcome to .NET File Handling"
);


Console.WriteLine("File created successfully");


// Read data from file

string data =
    File.ReadAllText(filePath);


Console.WriteLine(
    "File Content: " + data
);



// Append data

File.AppendAllText(
    filePath,
    "\nAdding new line"
);


Console.WriteLine(
    "Data appended"
);