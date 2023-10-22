using DependencyInversionPrinciple;

List<Customer> customers = new List<Customer>()
{
    new Customer {Id=1, Name = "ahmed", Email="ahmed@gmail.com", MobileNo="0612897654"},
    new Customer {Id=2, Name = "imane", Email="imane@gmail.com", MobileNo="0614597654"},
    new Customer {Id=3, Name = "aymen", Email="ahmed@gmail.com", MobileNo="0619097654"},
};

foreach(Customer customer in customers)
{
    //1 ------------------------------------------------------------------

    //constructor injection
    /*var services = new List<IMessage>
    {
        new SMSService() {MobileNo=customer.MobileNo},
        new EmailService() {Email=customer.Email},
    };
    NotificationService notificationService = new(services);
    notificationService.Send();*/
    //2 ------------------------------------------------------------------

    //property injection
    /*var notificationService = new NotificationService1();
    notificationService.SetServices(new List<IMessage>
    {
        new SMSService() {MobileNo=customer.MobileNo},
        new EmailService() {Email=customer.Email},
    });
    notificationService.Send();*/
    //3 ------------------------------------------------------------------

    //method injection
    var notificationService = new NotificationService2();
    notificationService.Send(new List<IMessage>
    {
        new SMSService() {MobileNo=customer.MobileNo},
        new EmailService() {Email=customer.Email},
    });
}