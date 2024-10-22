//Я не понял ни где тут мост, ни кто какие как сообщения отправлять, если что неправильно подойду на паре переспрошу.
new TXTNotifications(new NotificationsSMS()).Send("Сообщение.");


interface INotifications
{
    abstract void Send(string message);
}


class NotificationsSMS: INotifications
{
    public void Send(string message)
    {
        Console.WriteLine("Вам написали смс, " + message); //???
    }
}


class NotificationsHTML : INotifications
{
    public void Send(string message)
    {
        Console.WriteLine("Вам написали Email, " + message); //???
    }
}


abstract class Notifications
{
    protected INotifications notifications;
    public Notifications(INotifications A)
    {
        notifications = A;
    }
    abstract public void Send(string message);
}


class TXTNotifications : Notifications
{
    public TXTNotifications(INotifications A) : base(A) { }
    public override void Send(string message)
    {
        notifications.Send("текст: " + message); //???
    }
}


class HTMLNotifications : Notifications
{
    public HTMLNotifications(INotifications A) : base(A) { }
    public override void Send(string message)
    {
        notifications.Send("что-то: " + message); //???
    }
}