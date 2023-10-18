using System;
using System.Collections.Generic;
using System.Xml.XPath;
using WhatsAppApiUCU;


namespace Library
{
    public class Phonebook
    {
        private List<Contact> people;
        private IMessageChannel messageChannel;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.people = new List<Contact>();

            this.messageChannel = new WhatsAppChannel();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.people)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

         public void AddContact(Contact contact)
        {
            //Contact contact = new Contact(name, phone, email);
            people.Add(contact);
        }

        public void DeleteContact(Contact contact)
        {
            people.Remove(contact);
        }

        public Contact GetContact(string contactName)
        {
            foreach (Contact contact in people)
            {
                if (contact.Name == contactName)
                {
                    return contact;
                }
            }
            return null;
        }

        public void SendMessage(Contact from, Contact to, string text)
        {
            Message message = messageChannel.CreateMessage(from, to, text);
            WhatsAppApi.Send(to,message);
        }
    }
}