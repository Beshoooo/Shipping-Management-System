﻿    using Shipping.Models;

namespace Shipping.ViewModels
{
    public class OrderViewModel
    {
        public int? Id { get; set; }
        public string ClientName { get; set; }
        public int ClientPhoneNumber1 { get; set; }
        public int? ClientPhoneNumber2 { get; set; }
        public string ClientEmail { get; set; }
        public int OrderCost { get; set; }
        public int TotalWeight { get; set; }
        public bool IsVillage { get; set; } = false;
        public string? StateName { get; set; }
        public string CityName { get; set; }
        public string BranchName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string StreetName { get; set; }
        public string? Notes { get; set; }
        public bool IsDeleted { get; set; }
        public int ShippingCost { get; set; }
        public int? TotalCost { get; set; } 
        public List<OrderProduct> orderProducts { get; set; }

        /* hussen */

        public int? BranchId { get; set; }

        public int? DeliveryId { get; set; }

        public int? MerchantId { get; set; }


        /* hussen*/

        public Models.Type Type { get; set; }
        public ShippingType ShippingType { get; set; }
        public PaymentType PaymentType { get; set; }
        public string? OrderStatus { get; set; }

    }
}
