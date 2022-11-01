using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
   public class InventoryModel
    {

        public CommonProperties Rice { get; set; }
        public CommonProperties Pulses { get; set; }
        public CommonProperties Wheats { get; set; }
    }
    public class CommonProperties
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public int PricePerKG { get; set; }
    }
}
