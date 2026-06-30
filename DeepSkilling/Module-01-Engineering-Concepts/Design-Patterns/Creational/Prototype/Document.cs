namespace Prototype;

public class Document : ICloneable
{

    public string Title { get; set; }

    public string Content { get; set; }


    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }


    public object Clone()
    {
        return new Document(
            this.Title,
            this.Content
        );
    }


    public void Display()
    {
        Console.WriteLine(
            $"Title: {Title}"
        );

        Console.WriteLine(
            $"Content: {Content}"
        );
    }

}