using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01
{
    class SouthIndianItem : IMenuItem
    {
        public bool IsSpicy { get; private set; }

        #region IMenuItem members

        public string ItemName { get; private set; }
        public int Price { get; private set; }

        #endregion

        public SouthIndianItem(string item, int price, bool isspicy = false)
        {
            this.ItemName = item;
            this.Price = price;
            this.IsSpicy = isspicy;
        }
    }
}
