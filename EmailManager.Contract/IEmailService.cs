using EmailManager.Messaging.Request;
using EmailManager.Messaging.Response;

namespace EmailManager.Contract
{
    public interface IEmailService
    {
        Task<GetEmailsResponse> GetEmailsAsync();

        Task<CreateEmailResponse> CreateEmailAsync(CreateEmailRequest request);
    }
}
