using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementProgram
{
    public static class Inventory
    {

        //public properties 
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        //public methods
        public static void addProduct(Product product) //adds a product object to the BindingList named Products
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID) //removes product object that corresponds to the productID that is passed in. Returns true or false.
        {
            bool removedSuccessfully = false;
            foreach (Product item in Products)
            {
                if (item.ProductID == productID)
                {
                    Products.Remove(item);
                    removedSuccessfully = true;
                    return removedSuccessfully;
                    break;
                }
            }
            return removedSuccessfully;
        }
        public static Product lookupProduct(int productID) //returns a copy of the Product item corresponding to the productID passed into the method.
        {
            foreach (Product item in Products)
            {
                if (item.ProductID == productID)
                {
                    return item;
                }
            }
            return null;
        }
        public static void updateProduct(int productID, Product product) //updates the fields of an existing Product item within the AllProducts BindingList
        {
            foreach (Product item in Products)
            {
                if (item.ProductID == productID)
                {
                    item.AssociatedParts = product.AssociatedParts;
                    item.Name = product.Name;
                    item.Price = product.Price;
                    item.InStock = product.InStock;
                    item.Min = product.Min;
                    item.Max = product.Max;
                    break;
                }
            }
        }
        
        public static void addPart(InHouse part) //adds the passed part parameter to the AllParts BindingList
        {
            AllParts.Add(part);

        }
        public static void addPart(Outsourced part) //adds the passed part parameter to the AllParts BindingList
        {
            AllParts.Add(part);

        }
        public static bool  deletePart(Part part) //removes part object from the AllParts BindingList.
        {
            bool removedSuccessfully = false;
            foreach (Part item in AllParts)
            {
                if (item == part)
                {
                    AllParts.Remove(item);
                    removedSuccessfully = true;
                    return removedSuccessfully;
                    break;
                }
            }
            return removedSuccessfully;
        }
        public static Part lookupPart(int partID) //returns a part object corresponding to the partID parameter.
        {
            foreach (Part item in AllParts)
            {
                if (item.PartID == partID)
                {
                    return item;
                }
            }
            return null;
        }
        public static void updatePart(int partID, Part part) //removes existing part and replaces it with the one passed in via the method call.
        {
            foreach (Part item in AllParts)
            {
                if (item.PartID == partID)
                {
                    AllParts.Remove(item);
                    AllParts.Add(part);
                    break;
                }
            }
        }
        
    }
}
    