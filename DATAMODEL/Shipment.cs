namespace Courier_Management_System.DATA_MODEL
{
    public class Shipment
    {
        public int? Id { get; set; }
        public string? TrackingNumber { get; set; }
        public string? SenderName { get; set; }
        public string? ReceiverName { get; set; }
        public string? Status { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

    }
}
