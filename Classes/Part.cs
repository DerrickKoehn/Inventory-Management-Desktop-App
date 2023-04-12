using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProgram
{
    public abstract class Part
    {
        //Private Fields
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        //Accessors and mutators
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    
}
