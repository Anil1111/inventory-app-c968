﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryApp
{
    class Inventory
    {
        public static List<Product> products = new List<Product>();
        public static BindingList<Part> allParts = new BindingList<Part>();
        public BindingSource source = new BindingSource(allParts, null);

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

        public void AddPart(Part part)
        {
            allParts.Add(part);
            
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
