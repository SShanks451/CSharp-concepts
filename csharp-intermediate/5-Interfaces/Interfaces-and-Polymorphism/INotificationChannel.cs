namespace CSharp
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}