using EmailManager.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailManager.Model.Common
{
    public class ValidationEntity
    {
        #region Properties

        [NotMapped]
        public List<string> BrokenRules { get; set; }

        #endregion

        #region Constructors

        public ValidationEntity()
        {
            BrokenRules = new List<string>();
        }

        #endregion

        #region Public Methods

        public void AddBrokenRule(string message)
        {
            BrokenRules.Add(message);
        }

        public void ThrowExceptionIfThereAreBrokenRules()
        {
            if (BrokenRules != null && BrokenRules.Any())
            {
                throw new ValidationEntityException(FormatBrokenRulesForExceptionMessage());
            }
        }

        #endregion

        #region Private Methods

        private string FormatBrokenRulesForExceptionMessage()
        {
            return String.Join(Environment.NewLine, BrokenRules);
        }

        #endregion
    }
}
