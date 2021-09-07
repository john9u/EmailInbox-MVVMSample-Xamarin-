using EmailInboxXamarin.Models;
using EmailInboxXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailInboxXamarin.ViewModels
{
    public class InboxViewModel : INotifyPropertyChanged
    {
        private Mail _selectedMail;
        public Mail SelectedMail
        {
            get
            {
                return _selectedMail;
            }
            set
            {
                _selectedMail = value;
                if (_selectedMail != null) SelectedCommand.Execute(_selectedMail);
            }
        }
        public InboxViewModel()
        {
            SelectedCommand = new Command<Mail>(OnMailSelected);
            AddCommand = new Command(OnAddMail);
            DeleteCommand = new Command<Mail>(OnDeleteMail);
        }

        private void OnDeleteMail(Mail mail)
        {
            Mails.Remove(mail);
        }

        private async void OnAddMail()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddEmailPage(Mails));
        }

        private async void OnMailSelected(Mail mail)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(mail));
        }

        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SelectedCommand { get; }
        public ICommand AddCommand { get; }

        public ICommand DeleteCommand { get; set; }
    }
}
