namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
         public Message CreateMessage(Contact from, Contact to, string text);
    }
}