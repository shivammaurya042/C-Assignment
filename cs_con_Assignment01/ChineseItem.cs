using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01
{
    class ChineseItem : IMenuItem
    {
        public bool isIndianChinese { get; private set; }
        public bool ContainsMSG { get; private set; }

        #region IMenuItem members

        public string ItemName { get; private set; }
        public int Price { get; private set; }

        #endregion

        public ChineseItem(string item, int price, bool isMSG = false, bool isIndian = true)
        {
            this.ItemName = item;
            this.Price = price;
            this.ContainsMSG = isMSG;
            this.isIndianChinese = isIndian;
        }
    }
}
