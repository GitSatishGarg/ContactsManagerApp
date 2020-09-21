using LearningForms.Classes;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using SQLite;

namespace LearningForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                LastName = lastnameEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Email = emailEntry.Text,
                Address = addressEntry.Text

            };

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Contact>();
                int rowsAdded = conn.Insert(contact);
            }
        }
    }
}
