using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse(int partID, string name, double price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        public override string GetMagicVar()
        {
            return MachineID.ToString();
        }
    }
}
