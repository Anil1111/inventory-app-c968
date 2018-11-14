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

        public void AddProduct(object product)
        {
            //add product to products
            return;
        }

        public bool RemoveProduct(int id)
        {
            //remove product by id
            return true;
        }

        //public Product lookupProduct(int id)
        //{
        //    return;
        //}

        public void UpdateProduct(int id, Product product)
        {
            return;
        }

        public static void AddPart(Part part)
        {
            return;
        }

        public bool DeletePart(Part part)
        {
            return true;
        }

        //public Part lookupPart(int id)
        //{
        //    return;
        //}

        public void UpdatePart(int id, Part part)
        {
            return;
        }
    }
}
