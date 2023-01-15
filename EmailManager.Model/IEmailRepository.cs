namespace EmailManager.Model
{
    public interface IEmailRepository
    {
        Task<IEnumerable<Message>> GetMessagesAsync();

        Task CreateMessageAsync(Message message);
    }
}
