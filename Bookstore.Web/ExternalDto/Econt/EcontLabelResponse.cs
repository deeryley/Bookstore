namespace Bookstore.Web.Econt
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LabelResponse
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Label Label { get; set; }

        [JsonProperty("blockingPaymentURL")]
        public object BlockingPaymentUrl { get; set; }
    }

    public partial class Label
    {
        [JsonProperty("shipmentNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipmentNumber { get; set; }

        [JsonProperty("storageOfficeName")]
        public object StorageOfficeName { get; set; }

        [JsonProperty("storagePersonName")]
        public object StoragePersonName { get; set; }

        [JsonProperty("createdTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }

        [JsonProperty("sendTime")]
        public object SendTime { get; set; }

        [JsonProperty("deliveryTime")]
        public object DeliveryTime { get; set; }

        [JsonProperty("senderDeliveryType")]
        public object SenderDeliveryType { get; set; }

        [JsonProperty("senderAgent")]
        public object SenderAgent { get; set; }

        [JsonProperty("senderOfficeCode")]
        public object SenderOfficeCode { get; set; }

        [JsonProperty("receiverDeliveryType")]
        public object ReceiverDeliveryType { get; set; }

        [JsonProperty("receiverAgent")]
        public object ReceiverAgent { get; set; }

        [JsonProperty("receiverOfficeCode")]
        public object ReceiverOfficeCode { get; set; }

        [JsonProperty("cdCollectedAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? CdCollectedAmount { get; set; }

        [JsonProperty("cdCollectedCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string CdCollectedCurrency { get; set; }

        [JsonProperty("cdCollectedTime")]
        public object CdCollectedTime { get; set; }

        [JsonProperty("cdPaidAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? CdPaidAmount { get; set; }

        [JsonProperty("cdPaidCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string CdPaidCurrency { get; set; }

        [JsonProperty("cdPaidTime")]
        public object CdPaidTime { get; set; }

        [JsonProperty("totalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalPrice { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("discountPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiscountPercent { get; set; }

        [JsonProperty("discountAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiscountAmount { get; set; }

        [JsonProperty("discountDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountDescription { get; set; }

        [JsonProperty("senderDueAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? SenderDueAmount { get; set; }

        [JsonProperty("receiverDueAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReceiverDueAmount { get; set; }

        [JsonProperty("otherDueAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherDueAmount { get; set; }

        [JsonProperty("deliveryAttemptCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeliveryAttemptCount { get; set; }

        [JsonProperty("previousShipmentNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousShipmentNumber { get; set; }

        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<Service> Services { get; set; }

        [JsonProperty("nextShipments", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> NextShipments { get; set; }

        [JsonProperty("trackingEvents", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> TrackingEvents { get; set; }

        [JsonProperty("pdfURL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PdfUrl { get; set; }

        [JsonProperty("expectedDeliveryDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpectedDeliveryDate { get; set; }

        [JsonProperty("returnShipmentURL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ReturnShipmentUrl { get; set; }
    }

    public partial class Service
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("paymentSide", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentSide { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public long? Price { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }
    }

    public partial class LabelResponse
    {
        public static LabelResponse FromJson(string json) => JsonConvert.DeserializeObject<LabelResponse>(json, Bookstore.Web.Econt.Converter.Settings);
    }

}
