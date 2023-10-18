namespace Library;
public class WhatsAppChannel : IMessageChannel
{

    public Message CreateMessage(string from, string to, string text)
    {
        return new WhatsAppMessage(to,text);
    }
}