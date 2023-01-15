using AutoMapper;
using EmailManager.Messaging.EmailViews;
using EmailManager.Model;

namespace EmailManager.Service.Mapper
{
    public class EmailMappingProfile : Profile
    {
        public EmailMappingProfile()
        {
            #region ToModel

            CreateMap<MessageView, Message>();

            #endregion

            #region ToView

            CreateMap<Message, MessageView>();

            #endregion
        }
    }
}
