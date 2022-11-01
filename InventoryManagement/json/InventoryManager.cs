using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagement
{
    public class InventoryManager
    {

        public string FilePath = @"R:\inventoryManagement\inventoryManagement\json\InventoryManager.json";
        
        public void CalculateInventoryValue()
        {
        var string? jsonData = File.ReadAllText(FilePath);
            
            var InventoryModel? inventoryData = JsonConvert.DeserializeObject<InventoryModel>(jsonData);

            Console.WriteLine(
                inventoryData.Wheats.Name+"\n"
                + inventoryData.Wheats.PricePerKG + "\n"
                + inventoryData.Wheats.Weight
                +"\n"+

                inventoryData.Pulses.Name + "\n"
               + inventoryData.Pulses.PricePerKG + "\n"
               +  inventoryData.Pulses.Weight
                + "\n" +

                inventoryData.Rice.Name + "\n"
              +  inventoryData.Rice.PricePerKG + "\n"
              +  inventoryData, Rice.Weight);

            int totalValueForPulse = inventoryData.Pulses.PricePerKG * inventoryData.Pulses.Weight;
            int totalValueForRice = inventoryData.Rice.PricePerKG * inventoryData.Rice.Weight;
            int totalValueForWheat = inventoryData.Wheat.PricePerKG * inventoryData.Wheat.Weight;

            Console.WriteLine(value: $"totalvalueForPulse::{totalValueForPulse}");
            Console.WriteLine(value: $"totalvalueForRice::{totalValueForRice}");
            Console.WriteLine(value: $"totalvalueForWheat::{totalValueForWheat}");





        }

    }
}
