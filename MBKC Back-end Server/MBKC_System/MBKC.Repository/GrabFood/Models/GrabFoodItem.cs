using MBKC.Repository.GrabFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBKC.Repository.GrabFood.Models
{
    public class GrabFoodItem
    {
        public int AvailableStatus { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public List<string>? LinkedModifierGroupIDs { get; set; }
        public int SortOrder { get; set; }
        public decimal PriceInMin { get; set; }

        public int Quantity { get; set; }
        public string Comment { get; set; }
        public List<GrabFoodModifierGroup> ModifierGroups { get; set; }
        public List<GrabFoodDiscount> DiscountInfo { get; set; }
    }
}
