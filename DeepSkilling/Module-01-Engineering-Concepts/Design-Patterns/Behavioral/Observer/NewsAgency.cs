namespace Observer;

public class NewsAgency : ISubject
{

    private List<IObserver> observers =
        new List<IObserver>();


    private string news;


    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }


    public void SetNews(string news)
    {
        this.news = news;

        Notify();
    }


    public void Notify()
    {
        foreach(var observer in observers)
        {
            observer.Update(news);
        }
    }

}
