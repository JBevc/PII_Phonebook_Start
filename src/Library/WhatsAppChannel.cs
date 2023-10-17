using WhattsAppApiUcu;
namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public void Send(Message message)
    {
        WhatsAppApi whatsApp = new WhatsAppApi();
        whatsApp.Send(message.To, message.Text);
    }

    public Message CreateMessage(Contact from, Contact to, string text)
    {
        return new WhatsAppMessage(to,text);
    }
}