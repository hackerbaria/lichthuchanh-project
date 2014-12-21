using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class Item
    {
        private String name;
        private int value;

        public Item(string name, int value)
        {
            this.name = name; 
            this.value = value;
        }

        public override string ToString()
        {
            // Generates the text shown in the combo box
            return name;
        }
    }
}
