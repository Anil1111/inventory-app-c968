using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Product
    {
        private List<Part> associatedParts = new List<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part)
        {
            //add part to associatedParts collection
            return;
        }

        public bool removeAssociatedPart(int id)
        {
            //remove part by id from associatedParts
            return true;
        }

        //public Part lookupAssociatedPart(int id)
        //{
        //    //lookup part by id in associatedParts
        //    return;
        //}
    }
}
