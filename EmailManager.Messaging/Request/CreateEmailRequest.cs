using EmailManager.Messaging.EmailViews;

namespace EmailManager.Messaging.Request
{
    public class CreateEmailRequest : RequestBase
    {
        public MessageView EmailMessage { get; set; }
    }
}
