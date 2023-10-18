namespace Library
{
    public interface IMessageChannel
    {
         public Message CreateMessage(Contact from, Contact to, string text);
    }
}