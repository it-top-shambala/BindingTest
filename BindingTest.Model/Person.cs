using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using BindingTest.Model.Annotations;

namespace BindingTest.Model
{
    public class Person : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            } 
        }

        private string _first;
        public string FirstName
        {
            get => _first;
            set
            {
                _first = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        
        private string _last;

        public string LastName
        {
            get => _last;
            set
            {
                _last = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private DateTime _date;
        public DateTime DateOfBirth
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}