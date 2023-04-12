using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementProgram
{
    public class Product
    {
        //private fields
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        //public accessors and mutators
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //constructor
        public Product(BindingList<Part> associatedParts, int productID, string name, decimal price, int inStock, int min, int max)
        {
            AssociatedParts = associatedParts;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        

        //public methods
        public void addAssociatedPart(Part part) //adds passed part to the BindingList named AssociatedParts for the current instance of the Product object
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID) //removes part object corresponding to passed partID from current instance of the Product object
        {
            bool removedSuccessfully = false;
            foreach (Part item in AssociatedParts)
            {
                if (item.PartID == partID)
                {
                    AssociatedParts.Remove(item); //there is a variable that regulates permission to remove items
                    removedSuccessfully = true;
                    return removedSuccessfully;
                    break;
                }
            }
            return removedSuccessfully; //testme I need to make sure it is actually removing items and returning the correct bool value
                
        }
        public Part lookupAssociatedPart(int partID) //returns part object corresponding to passed partID from currant instance of Product object.
        {
            foreach (Part item in AssociatedParts)
            {
                if (item.PartID == partID)
                {
                    return item;
                }
            }
            return null;
        }
    }

}
