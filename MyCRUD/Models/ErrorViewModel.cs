namespace MyCRUD.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int Age { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}