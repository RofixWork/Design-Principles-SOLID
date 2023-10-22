NotifcationService notifcationService = new(ServiceTypeFactory.Create(ServiceType.EMAIL));

notifcationService.Send("Hello my friend");

interface IService
{
    void Send(string message);
}

class EmailService : IService
{
    public void Send(string message)
    {
        Console.WriteLine("Sending...");
        Thread.Sleep(500);
        Console.WriteLine($"Email Message <{message}> hasn benn Sending...");
    }
}

class SmsService : IService
{
    public void Send(string message)
    {
        Console.WriteLine("Sending...");
        Thread.Sleep(500);
        Console.WriteLine($"SMS Message <{message}> hasn benn Sending...");
    }
}

class ServiceTypeFactory
{
    public static IService Create(ServiceType serviceType)
    {
        return serviceType switch
        {
            ServiceType.EMAIL => new EmailService(),
            ServiceType.SMS => new SmsService(),
            _ => new EmailService(),
        };
    }
}

enum ServiceType
{
    EMAIL, SMS
}

class NotifcationService
{
    private readonly IService _service;

    public NotifcationService(IService service)
    {
        _service = service;
    }
    public void Send(string message)
    {
        _service.Send(message);
    }

}