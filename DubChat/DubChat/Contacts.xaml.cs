using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DubChatLibrary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DubChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        public List<Contact> teste = new List<Contact>() {
                new Contact(){ Name ="Fernando Costa", Avatar = "me"},
                new Contact(){ Name ="Fernando Baltazar", Avatar = "me"},
                new Contact(){ Name ="Fernando Amando", Avatar = "me"},
                new Contact(){ Name ="Fernando Antonio", Avatar = "me"},
                new Contact(){ Name ="Bruno Costa", Avatar = "me"},
                new Contact(){ Name ="Zeze Camarinha", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},
                new Contact(){ Name ="Fernando Costa", Avatar = "me"},
                new Contact(){ Name ="Fernando Baltazar", Avatar = "me"},
                new Contact(){ Name ="Fernando Amando", Avatar = "me"},
                new Contact(){ Name ="Fernando Antonio", Avatar = "me"},
                new Contact(){ Name ="Bruno Costa", Avatar = "me"},
                new Contact(){ Name ="Zeze Camarinha", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},
                new Contact(){ Name ="Fernando", Avatar = "me"},

            };

        public Contacts()
        {
            InitializeComponent();
            ContactsListView.ItemsSource = teste.OrderBy(x=> x.Name);
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                ContactsListView.ItemsSource = teste.Where(x => x.Name.ToLower().Contains(SearchTextBox.Text.ToLower())).OrderBy(x => x.Name);
            }
            else
            {
                ContactsListView.ItemsSource = teste.OrderBy(x => x.Name);
            }

        }
    }
}