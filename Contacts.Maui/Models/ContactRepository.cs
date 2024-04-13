namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact() {Id=0,Name="Grikduime",Email="Grikduime@email.com"},
            new Contact() {Id=1,Name="Kiudoir",Email="Kiudoir@email.com"},
            new Contact() {Id=2,Name="Veikennu",Email="Veikennu@email.com"},
            new Contact() {Id=3,Name="Silrunyo",Email="Silrunyo@email.com"},
            new Contact() {Id=4,Name="Piarar",Email="Piarar@email.com"}
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int id)
        {
            var contact = _contacts.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            {
                return new Contact
                {
                    Id = contact.Id,
                    Name = contact.Name,
                    Email = contact.Email,
                    Address = contact.Address,
                    Phone = contact.Phone,
                };
            }
            return null;
        }

        public static void UpdateContact(int id, Contact contact)
        {
            if (id != contact.Id) return;

            var contactUpdate = _contacts.FirstOrDefault(x => x.Id == id);
            if (contactUpdate != null)
            {
                contactUpdate.Address = contact.Address;
                contactUpdate.Phone = contact.Phone;
                contactUpdate.Email = contact.Email;
                contactUpdate.Name = contact.Name;
            }

        }
        public static void AddContact(Contact contact)
        {

            var maxId = _contacts.Max(x => x.Id);
            contact.Id = maxId + 1;
            _contacts.Add(contact);
        }
    }
}
