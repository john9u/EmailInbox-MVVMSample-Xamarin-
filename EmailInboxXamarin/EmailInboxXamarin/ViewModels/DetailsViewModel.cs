using EmailInboxXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmailInboxXamarin.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        public DetailsViewModel(Mail mail)
        {
            Mail = mail;
        }

        public Mail Mail { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
