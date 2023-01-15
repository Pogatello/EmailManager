using EmailManager.Model;
using Microsoft.EntityFrameworkCore;

namespace EmailManager.Repository
{
    public class EmailRepository : IEmailRepository
    {

        #region Fields

        private readonly AppDbContext _context;

        #endregion

        #region Constructors

        public EmailRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Public Methods

        public async Task<IEnumerable<Message>> GetMessagesAsync()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task CreateMessageAsync(Message message)
        {
            await _context.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        #endregion
    }
}
