using AutoMapper;
using EmailManager.Contract;
using EmailManager.Infrastructure;
using EmailManager.Messaging.EmailViews;
using EmailManager.Messaging.Request;
using EmailManager.Messaging.Response;
using EmailManager.Model;

namespace EmailManager.Service
{
    public class EmailService : IEmailService
    {
        #region Fields

        private readonly IEmailRepository _emailRepository;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors

        public EmailService(IEmailRepository emailRepository, IMapper mapper)
        {
            _emailRepository = emailRepository;
            _mapper = mapper;
        }

        #endregion

        #region Public methods

        public async Task<GetEmailsResponse> GetEmailsAsync()
        {
            var response = new GetEmailsResponse();

            try
            {
                var messages = await _emailRepository.GetMessagesAsync();

                response.Messages = _mapper.Map<IEnumerable<MessageView>>(messages);
                response.Success = true;
            }
            catch (Exception)
            {
                response.ErrorMessage = "There was an error. Please try again later.";
            }

            return response;
        }

        public async Task<CreateEmailResponse> CreateEmailAsync(CreateEmailRequest request)
        {
            var response = new CreateEmailResponse();

            try
            {
                var email = _mapper.Map<Message>(request.EmailMessage);
                email.Validate();

                await _emailRepository.CreateMessageAsync(email);

                response.Success = true;
            }
            catch (ValidationEntityException ex)
            {
                response.ErrorMessage = ex.Message;
            }
            catch (Exception)
            {
                response.ErrorMessage = "There was an error. Please try again later.";
            }

            return response;
        }

        #endregion
    }
}
