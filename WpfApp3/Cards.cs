using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Cards
    {
        public ObservableCollection<Card> C = new ObservableCollection<Card>();

        public Cards()
        {
            C.Add(new Card("10"));
            C.Add(new Card("22"));
        }

        public ObservableCollection<Card> CC
        {
            get
            {
                return C;
            }

            
        }

        public void Update(int x, string v)
        {
            C[x].Number = v;
        }


    }
}
