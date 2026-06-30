using Newtonsoft.Json;


class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

}



class Program
{

    static void Main()
    {

        Student student = new Student()
        {
            Id = 1,
            Name = "Nagarjuna"
        };


        // Object to JSON

        string json =
            JsonConvert.SerializeObject(student);


        Console.WriteLine(json);



        // JSON to Object

        Student result =
            JsonConvert.DeserializeObject<Student>(json);



        Console.WriteLine(
            result.Name
        );

    }

}