namespace ContactManagementSystem
{
    public interface IContactStorage
    {
        LoadContacts();
        SaveContacts(List<Contact> contacts);

    }
}
