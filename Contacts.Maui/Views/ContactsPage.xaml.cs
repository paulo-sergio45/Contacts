namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = new List<Contact>()
        {
            new Contact() {Name="Grikduime",Email="Grikduime@email.com"},
             new Contact() {Name="Kiudoir",Email="Kiudoir@email.com"},
              new Contact() {Name="Veikennu",Email="Veikennu@email.com"},
               new Contact() {Name="Silrunyo",Email="Silrunyo@email.com"},
                new Contact() {Name="Piarar",Email="Piarar@email.com"}
        };



        listContacts.ItemsSource = contacts;
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }

}