using EmailManager.Model.Common;
using System.ComponentModel.DataAnnotations;

namespace EmailManager.Model
{
    public class Message : ValidationEntity
	{
        #region Properties

        [Key]
        public long Id { get; set; }

        public string From { get; set; }

		public string To { get; set; }
		
		public string? CC { get; set; }
		
		public string Subject { get; set; }

		public Priority Priority { get; set; }

		public string Content { get; set; }

        #endregion

        #region Public Methods

		public void Validate()
		{
			if (string.IsNullOrWhiteSpace(From))
			{
				AddBrokenRule("From field is required");
            }
            else if (!IsValidEmail(From))
            {
                AddBrokenRule("From field requires a valid email address.");
            }

            if (string.IsNullOrWhiteSpace(To))
            {
                AddBrokenRule("To field is required");
            }
            else if (!IsValidEmail(To))
            {
                AddBrokenRule("To field requires a valid email address.");
            }

            if (string.IsNullOrWhiteSpace(Subject))
            {
                AddBrokenRule("Subject field is required");
            }

            if (Priority == Priority.Undefined)
            {
                AddBrokenRule("Priority field is required");
            }

            if (string.IsNullOrWhiteSpace(Content))
            {
                AddBrokenRule("Content field is required");
            }

            base.ThrowExceptionIfThereAreBrokenRules();
        }

        #endregion

        #region Private Methods

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
