using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProgram
{
    public class InHouse : Part
    {
        //Private Field
        private int machineID;

        //Public accessor and mutator
        public int MachineID { get; set; }

        //Custom Constructor
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.MachineID = machineID;
        }
    }
}
