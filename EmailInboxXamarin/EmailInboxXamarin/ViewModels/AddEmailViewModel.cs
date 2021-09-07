using EmailInboxXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailInboxXamarin.ViewModels
{
    public class AddEmailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Mail> _mails;
        public ICommand AddCommand { get; }
        public string From { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
       
        public AddEmailViewModel(ObservableCollection<Mail> mails)
        {
            _mails = mails;
            AddCommand = new Command(() =>
            {
                mails.Add(new Mail(From, Title, Description, DateTime.Now.ToString("MMMM dd"),Content));
                App.Current.MainPage.Navigation.PopAsync();

            });
        }


    }
}
