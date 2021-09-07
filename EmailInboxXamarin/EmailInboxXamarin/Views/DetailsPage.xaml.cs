using EmailInboxXamarin.Models;
using EmailInboxXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailInboxXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Mail mail)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(mail);
        }
    }
}