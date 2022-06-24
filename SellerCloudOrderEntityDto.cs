using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public class OrderDetails
    {
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int SiteCode { get; set; }
        public int OrderSource { get; set; }
        public string OrderSourceOrderId { get; set; }
        public object OrderSourceOrderIdUrl { get; set; }
        public string EbaySellingManagerSalesRecordNumber { get; set; }
        public object EbayUserId { get; set; }
        public object EbayUserUrl { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerID { get; set; }
        public int SalesRep1 { get; set; }
        public int SalesRep2 { get; set; }
        public int SalesRep3 { get; set; }
        public DateTime PromiseDate { get; set; }
        public bool DisplayPromiseDate { get; set; }
        public object EstimatedOrderDeliveryDate { get; set; }
        public int CurrencyCode { get; set; }
        public string OrderDate { get; set; }
        public string CreatedOn { get; set; }
        public int OrderSubType { get; set; }
        public object EbayOrdersSource3 { get; set; }
        public object EbayOrdersSource3Url { get; set; }
        public bool DisableOrderSourceOrderID { get; set; }
        public bool IsOrderLocked { get; set; }
        public object LockedByUser { get; set; }
        public int LockedTimeLeft { get; set; }
        public bool IsModified { get; set; }
    }

    public class Statuses
    {
        public int OrderStatus { get; set; }
        public int ShippingStatus { get; set; }
        public int PaymentStatus { get; set; }
        public bool RushOrder { get; set; }
        public int DropshipStatus { get; set; }
        public int CustomerServiceStatus { get; set; }
        public bool IsDelivered { get; set; }
        public int BackorderStatus { get; set; }
        public bool IsInvoicePrinted { get; set; }
        public bool IsExported { get; set; }
        public bool InventoryDisabled { get; set; }
        public int OkToProcess { get; set; }
        public int OkToShip { get; set; }
        public bool QBExported { get; set; }
        public bool Confirmed { get; set; }
        public bool FeedbackReceived { get; set; }
        public bool ShippingVerified { get; set; }
        public bool ChannelNotifiedOfShipping { get; set; }
        public bool FinalSale { get; set; }
        public int PickingStatus { get; set; }
        public string InPicklist { get; set; }
        public string IsInvoiced { get; set; }
        public string IsInGroup { get; set; }
        public bool IsBlackListed { get; set; }
        public object SkubloxStatus { get; set; }
        public int AddressVerifiedStatus { get; set; }
    }

    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string ProductID { get; set; }
        public object _ProductIDInitial { get; set; }
        public string ProductIDOriginal { get; set; }
        public string ProductIDRequested { get; set; }
        public bool ItemProductIdExists { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public string ImageURL { get; set; }
        public int Qty { get; set; }
        public bool TaxExempt { get; set; }
        public string SitePrice { get; set; }
        public string PricePerCase { get; set; }
        public int TotalCases { get; set; }
        public int QtyPerCase { get; set; }
        public string EBayItemID { get; set; }
        public object EBayItemUrl { get; set; }
        public int InventoryAvailableQty { get; set; }
        public int WarehouseID { get; set; }
        public List<object> BundleItems { get; set; }
        public int BackOrderQty { get; set; }
        public int QtyReturned { get; set; }
        public int QtyPicked { get; set; }
        public string Notes { get; set; }
        public string LineTotal { get; set; }
        public string DiscountValue { get; set; }
        public int DiscountType { get; set; }
        public bool CanBeDeleted { get; set; }
        public string AdjustedSitePrice { get; set; }
        public object ShadowOf { get; set; }
        public string LineTaxTotal { get; set; }
        public string ShippingCost { get; set; }
        public string ShippingTax { get; set; }
        public int RowStatus { get; set; }
        public bool IsModified { get; set; }
    }

    public class TotalInfo
    {
        public string SubTotal { get; set; }
        public string Discount { get; set; }
        public object PromoCode { get; set; }
        public string ShippingDiscount { get; set; }
        public string Tax { get; set; }
        public string TaxRate { get; set; }
        public string CustomTaxRate { get; set; }
        public string Shipping { get; set; }
        public string Handling { get; set; }
        public string Insurance { get; set; }
        public string GiftWrap { get; set; }
        public bool ShouldDisplayWrapFee { get; set; }
        public string GrandTotal { get; set; }
        public bool ForceUseFixedTaxAmount { get; set; }
        public bool IsModified { get; set; }
    }

    public class PaymentOptions
    {
        public object PaymentTerms { get; set; }
        public double Total { get; set; }
        public double Received { get; set; }
        public double Uncleared { get; set; }
        public double Refunded { get; set; }
        public double RemainingDues { get; set; }
    }

    public class EstShipWeight
    {
        public double Pounds { get; set; }
        public double Ounces { get; set; }
    }

    public class ShippingDetails
    {
        public int ShippingStatus { get; set; }
        public string Carrier { get; set; }
        public string Service { get; set; }
        public bool RushOrder { get; set; }
        public bool RequirePINToShip { get; set; }
        public DateTime OrderShippingPromiseDate { get; set; }
        public object ShipDate { get; set; }
        public double ShippingTotal { get; set; }
        public double ShippingDiscountsTotal { get; set; }
        public double CostOfShipping { get; set; }
        public EstShipWeight EstShipWeight { get; set; }
        public int ShippedBy { get; set; }
        public string ShippedByUser { get; set; }
        public int ShippingLocation { get; set; }
        public int ShippingStation { get; set; }
        public bool LockShippingMethod { get; set; }
        public bool AllowShippingWithoutPaymentValue { get; set; }
        public bool AllowShippingWithoutPaymentVisible { get; set; }
        public object OtherCarrier { get; set; }
        public object OtherMethed { get; set; }
        public object RequestedShippingBy { get; set; }
        public bool MaximumOrderItemsToDisplaySetting { get; set; }
        public object OrderItemCount { get; set; }
        public bool IsModified { get; set; }
    }

    public class Item
    {
        public int OrderID { get; set; }
        public int PackageID { get; set; }
        public int OrderItemID { get; set; }
        public int OrderItemBundleItemID { get; set; }
        public string ProductID { get; set; }
        public int Qty { get; set; }
        public string ItemName { get; set; }
    }

    public class OrderPackage
    {
        public int ID { get; set; }
        public string TrackingNumber { get; set; }
        public object TrackingNumberUrl { get; set; }
        public object TrackingNumberText { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double ShippingCost { get; set; }
        public double FinalShippingFee { get; set; }
        public object EstimatedDeliveryDate { get; set; }
        public object DeliveryDate { get; set; }
        public int DeliveryStatus { get; set; }
        public double DeclaredValue { get; set; }
        public List<Item> Items { get; set; }
        public bool EnableOrderShipmentTrackingAPI { get; set; }
    }

    public class ShippingAddress
    {
        public bool IsShippingAddress { get; set; }
        public bool IsBillingAddress { get; set; }
        public int AddressClassification { get; set; }
        public string Notes { get; set; }
        public string HomePhone { get; set; }
        public string EmailAddress { get; set; }
        public int AddressStatus { get; set; }
        public int AddressSource { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebSiteURL { get; set; }
    }

    public class BillingAddress
    {
        public bool IsShippingAddress { get; set; }
        public bool IsBillingAddress { get; set; }
        public int AddressClassification { get; set; }
        public string Notes { get; set; }
        public string HomePhone { get; set; }
        public string EmailAddress { get; set; }
        public int AddressStatus { get; set; }
        public int AddressSource { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebSiteURL { get; set; }
    }

    public class Payments
    {
        public int ID { get; set; }
        public string TransactionReferenceNumber { get; set; }
        public double PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentType { get; set; }
        public int PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }
    }

    public class ProfitAndLoss
    {
        public string ItemCost { get; set; }
        public object ItemCostUsd { get; set; }
        public string PostingFee { get; set; }
        public object PostingFeeUsd { get; set; }
        public string Comission { get; set; }
        public object ComissionUsd { get; set; }
        public string TransactionFee { get; set; }
        public object TransactionFeeUsd { get; set; }
        public string ShippingCost { get; set; }
        public object ShippingCostUsd { get; set; }
        public object ShippingCostTooltip { get; set; }
        public string Tax { get; set; }
        public object TaxUsd { get; set; }
        public string Promotion { get; set; }
        public object PromotionUsd { get; set; }
        public string Rebates { get; set; }
        public object RebatesUsd { get; set; }
        public string OrderCost { get; set; }
        public object OrderCostUsd { get; set; }
        // public string Payments { get; set; }
        public bool PaymentsVisible { get; set; }
        public object PaymentsUsd { get; set; }
        public string Adjustments { get; set; }
        public object AdjustmentsUsd { get; set; }
        public string DropShipFee { get; set; }
        public object DropShipFeeUsd { get; set; }
        public string ShippingClaim { get; set; }
        public string ProfitLoss { get; set; }
        public object ProfitLossUsd { get; set; }
        public object ProfitLossForParentOrder { get; set; }
        public object ProfitForParentOrderTooltip { get; set; }
        public object QbeExported { get; set; }
        public int CurrencyCode { get; set; }
    }

    public class GiftDetails2
    {
        public bool UseGiftWrap { get; set; }
        public double GiftWrapFee { get; set; }
        public object GiftMessage { get; set; }
        public object GiftWrapType { get; set; }
        public int OrderID { get; set; }
        public bool IsGiftOrder { get; set; }
        public bool IsWholeSaleOrder { get; set; }
        public bool HasOrderItems { get; set; }
        //  public GiftDetails GiftDetails { get; set; }
    }

    public class SellerCloudOrderEntityDto
    {
        public int OrderID { get; set; }
        public int ID { get; set; }
        public string OrderSourceOrderID { get; set; }
        public int OrderSource { get; set; }
        public int OrderSubType { get; set; }
        public int PaymentStatus { get; set; }
        public int StatusCode { get; set; }
        public OrderDetails OrderDetails { get; set; }
        public int Dropship { get; set; }
        public string FirstName { get; set; }
        public Statuses Statuses { get; set; }
        public string TimeOfOrder { get; set; }
        // public int GrandTotal { get; set; }
        public string CompanyName { get; set; }
        public int UserID { get; set; }
        public string OrderShippingPromiseDate { get; set; }
        public string CreatedOn { get; set; }
        public string Country { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<object> RelatedOrders { get; set; }
        public TotalInfo TotalInfo { get; set; }
        public PaymentOptions PaymentOptions { get; set; }
        public ShippingDetails ShippingDetails { get; set; }
        public List<OrderPackage> OrderPackages { get; set; }
        public DateTime LastUpdated { get; set; }
        public string OrderSiteCode { get; set; }
        public string DestinationCountry { get; set; }
        public bool OrderItemDiscountAllowed { get; set; }
        public bool EnableCaseQty { get; set; }
        public bool ShowProductImageOnOrderDetailPage { get; set; }
        public bool HideBackOrdersColumnInManageOrders { get; set; }
        public bool DisplayLocationNotesOnOrderItemsGrid { get; set; }
        public bool EnableWarehouseBins { get; set; }
        public bool EnableSecondSalesRep { get; set; }
        public int RmaID { get; set; }
        public bool IsWholeSaleOrder { get; set; }
        public string MostExpensiveSKU { get; set; }
        public bool RequirePinToSetCancelledOrdersToInProcess { get; set; }
        public bool ForceEnterCommentsWhenSettingOrderToOnHoldOrProblem { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public int StoreType { get; set; }
        public List<Payments> Payments { get; set; }
        //  public Payments Payments { get; set; }
        public ProfitAndLoss ProfitAndLoss { get; set; }
        public List<object> CustomColumns { get; set; }
        // public GiftDetails GiftDetails { get; set; }
        public bool RequireSignatureConfirmation { get; set; }
    }
}
