namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
         public Message CreateMessage(string from, string to, string text);
    }
}