using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ContactManagementSystem
{
    public class FileContactStorage : IContactStorage
    {
        private readonly string filePath = "contacts.json";
        public List<Contact> LoadContacts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Contact>>(json);
            }
            else
            {
                return new List<Contact>();
            }
            // Load contacts from JSON file if exists, else return new list

            // Use JsonSerializer.Deserialize to convert JSON string to List<Contact>
            
        }

        public void SaveContacts(List<Contact> contacts)
        {
            // Save contacts to JSON file
            // Use JsonSerializer.Serialize with WriteIndented option for pretty print
            throw new NotImplementedException();
        }

        public ContactManagementSystem.contact(int id, string name, string phoneNumber, string email)
        {
            
        }

        /* public class ContactManager
        {
            public List<Contact> Contacts { get; set; } = new List<Contact>();

            // Existing code...

            
        }
                public class ContactManager
        {
            public List<Contact> Contacts { get; set; } = new List<Contact>();

            // Existing code...

            
        } */

    }
}
