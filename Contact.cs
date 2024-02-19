namespace ContactManagementSystem
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class ContactManager
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            // Add contact's name to list
            System.Console.WriteLine("Please enter the contact's name: ");
            contact.Name = System.Console.ReadLine();

            // Add contact's phone number to list
            System.Console.WriteLine("Please enter the contact's phone number: ");
            contact.PhoneNumber = System.Console.ReadLine();

            // Add contact's email to list
            System.Console.WriteLine("Please enter the contact's email: ");
            contact.Email = System.Console.ReadLine();

            if (string.IsNullOrWhiteSpace(contact.Name) || string.IsNullOrWhiteSpace(contact.PhoneNumber) || string.IsNullOrWhiteSpace(contact.Email))
            {
                System.Console.WriteLine("Invalid input, please try again.");
                return;
            }
            else
            {
                Contacts.Add(contact);
                System.Console.WriteLine("Contact added successfully!");
            }
        }

        public Contact ViewContact(int id)
        {
            System.Console.WriteLine("Please enter the contact's id: ");
            id = int.Parse(System.Console.ReadLine());

            foreach (var contact in Contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }

            return null; // Return null if no contact with the given id is found
        }

        public bool UpdateContact(int id, string newName, string newPhoneNumber, string newEmail)
        {
            foreach (var contact in Contacts)
            {
                if (contact.Id == id)
                {
                    contact.Name = newName;
                    contact.PhoneNumber = newPhoneNumber;
                    contact.Email = newEmail;
                    return true; // Return true if the contact was found and updated
                }
            }

            return false; // Return false if no contact with the given id was found
        }
    }
}