using System.Net.Mail;

namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public Message CreateMessage(Contact from, Contact to, string text)
    {
        return new WhatsAppMessage(to,text);
    }
}