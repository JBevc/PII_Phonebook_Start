namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact from, Contact to) :
        base(from.Phone, to.Phone)
    {
        // Intencionalmente en blanco
    }
}