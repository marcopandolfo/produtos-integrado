using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newGUI
{
    class Produto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string brand { get; set; }

        public Produto(string name, string price, string description, string brand)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.brand = brand;
        }

        public Produto()
        {
        }
    }
}
