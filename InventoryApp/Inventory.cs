using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Inventory
    {
        private List<string> products;
        private List<string> allParts;

        public void addProduct(object product)
        {
            //add product to products
            return;
        }

        public bool removeProduct(int id)
        {
            //remove product by id
            return true;
        }

        //public Product lookupProduct(int id)
        //{
        //    return;
        //}

        public void updateProduct(int id, Product product)
        {
            return;
        }

        public void addPart(Part part)
        {
            return;
        }

        public bool deletePart(Part part)
        {
            return true;
        }

        //public Part lookupPart(int id)
        //{
        //    return;
        //}

        public void updatePart(int id, Part part)
        {
            return;
        }
    }
}
