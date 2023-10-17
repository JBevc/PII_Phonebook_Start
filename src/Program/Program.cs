using System;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
             // Crear el contacto dueño
            Contact julian = new Contact("Julian", "091952205");
            Contact belu = new Contact("Belu", "095446367");
            Contact bruno = new Contact("Flor", "092811036");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(julian);

            // Agregar contactos a la lista
            phonebook.AddContact(belu);
            phonebook.AddContact(bruno);

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            phonebook.SendMessage(belu, bruno, "Hola");

            // Enviar un SMS a algunos contactos
        }
    }
}

