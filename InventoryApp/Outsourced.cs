using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
            : base (partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public override string GetMagicVar()
        {
            return CompanyName;
        }
    }
}
