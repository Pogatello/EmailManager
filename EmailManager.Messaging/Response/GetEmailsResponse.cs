using EmailManager.Messaging.EmailViews;

namespace EmailManager.Messaging.Response
{
    public class GetEmailsResponse : ResponseBase
    {
        public IEnumerable<MessageView> Messages { get; set; }
    }
}
