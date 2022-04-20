using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class Chat : Request
    {
        private List<User> _users;
        private ObservableCollection<Message> _messages;

        public event Action<ObservableCollection<Message>> TakingMessage;

        public Chat()
        {
            _users = new List<User>();
            _messages = new ObservableCollection<Message>();
        }

        public void TakeMessage(Message message)
        {
            _messages.Add(message);
            TakingMessage?.Invoke(_messages);
        }

        public bool CheckUserName(string name)
        {
            return _users.Any<User>(x => x.FullName == name);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
