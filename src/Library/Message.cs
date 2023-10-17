namespace Library
{
    public class Message
    {
        protected Message(Contact from, Contact to, string text)
        {
            this.From = from;
            this.To = to;
            this.Text = text;
        }

        public string Text { get; set; }

        public Contact From { get; }

        public Contact To { get; }
    }
}