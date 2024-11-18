using Decorator;

public interface INotifier
{
    void Send(string message);
}
public class Notifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        INotifier notifier = new Notifier();

        notifier = new SmsNotifierDecorator(notifier);

        notifier = new FacebookNotifierDecorator(notifier);

        notifier.Send("Hello, this is a notification!");
    }
}
