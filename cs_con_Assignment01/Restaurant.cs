using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Assignment01
{
    class Restaurant
    {
        public string Name { get; private set; }
        public Menu TheMenu { get; private set; }

        public Restaurant(string name, params IMenuItem[] menuitems)
        {
            this.Name = name;

            this.TheMenu = new Menu();

            IMenuItem obj1 = new SouthIndianItem("Idly", 20);
            IMenuItem obj2 = new ChineseItem("Hakka Noodles", 120, isMSG: true);
            this.TheMenu.Add(obj1);
            this.TheMenu.Add(obj2);

            foreach(IMenuItem item in menuitems)
            {
                this.TheMenu.Add(item);
            }
        }
    }
}
