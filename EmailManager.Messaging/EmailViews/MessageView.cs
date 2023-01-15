using System.ComponentModel.DataAnnotations;

namespace EmailManager.Messaging.EmailViews
{
    public class MessageView
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "From field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string From { get; set; }

        [Required(ErrorMessage = "To field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string To { get; set; }

        public string CC { get; set; }

        [Required(ErrorMessage = "Subject field is required")]
        public string Subject { get; set; }

        public Priority Priority { get; set; }

        [Required(ErrorMessage = "Content field is required")]
        public string Content { get; set; }
    }
}
