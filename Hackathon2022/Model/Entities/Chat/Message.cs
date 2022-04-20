using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class Message : INotifyPropertyChanged
    {
        private string _text;
        private User _sender;
        private DateTime _date;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public User Sender
        {
            get => _sender;
            set
            {
                _sender = value;
                OnPropertyChanged(nameof(Sender));
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public Message(string text, User sender, DateTime date)
        {
            _text = text;
            _sender = sender;
            _date = date;
        }

        public Message(Message message, User owner)
        {
            Text = message.Text;
            Date = message.Date;
            Sender = message.Sender;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
