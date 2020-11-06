using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Board
    {
        private Cards g;
        public Board()
        {
            g = new Cards();
        }

        public Cards ccc
        {
            get
            {
                return g;
            }


        }
      
        public void Change(int x, string v)
        {
            g.Update(x, v);
        }

    }
}
