namespace EmailManager.Infrastructure
{
    public class ValidationEntityException : Exception
    {
        public ValidationEntityException(string message)
            : base(message)
        {
        }
    }
}
