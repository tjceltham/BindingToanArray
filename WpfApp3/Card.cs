using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp3
{

        class Card : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private string number;
            public Card(string x)
            {
                number = x;
            }
            public string Number
            {
                get
                {
                    return number;
                }

                set
                {
                    number = value;
                    OnPropertyChanged("Number");
                }
            }

            void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
