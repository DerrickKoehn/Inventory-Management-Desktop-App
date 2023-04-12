using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProgram
{
    public class Outsourced : Part
    {
        //Private Field
        private string companyName;

        //Public accessor and mutator
        public string CompanyName { get; set; }

        //Custom Constructor
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.CompanyName = companyName;
        }
    }
}
