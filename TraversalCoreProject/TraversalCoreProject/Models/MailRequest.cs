namespace TraversalCoreProject.Models
{
    public class MailRequest
    {
        public string Name { get; set; }=string.Empty;
        public string SenderEmail { get; set; }=string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string ReceiverMail {  get; set; } = string.Empty;

    }
}