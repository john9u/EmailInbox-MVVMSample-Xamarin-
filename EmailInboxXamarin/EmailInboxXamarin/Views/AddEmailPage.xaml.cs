using EmailInboxXamarin.Models;
using EmailInboxXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailInboxXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmailPage : ContentPage
    {
        public AddEmailPage(ObservableCollection<Mail> places)
        {
            InitializeComponent();
            BindingContext = new AddEmailViewModel(places);
        }
    }
}