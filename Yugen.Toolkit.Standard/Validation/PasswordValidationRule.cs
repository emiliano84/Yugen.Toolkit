﻿namespace Yugen.Toolkit.Standard.Validation
{
    /// <summary>
    /// The character limit validation rule.
    /// </summary>
    public class PasswordValidationRule : BaseValidationRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordValidationRule"/> class.
        /// </summary>
        public PasswordValidationRule()
        {
        }

        /// <summary>
        /// Gets the error message to display for the rule.
        /// </summary>
        public override string ErrorMessage => "Passwords do not match";

        /// <summary>
        /// Validates an object value with this rule.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="otherPassword"></param>
        /// The value to validate.
        /// <returns>
        /// Returns a boolean value indicating whether the object was validated with the rule.
        /// </returns>
        public bool IsValid(string password, string otherPassword)
        {
            if (otherPassword is null)
            {
                throw new System.ArgumentNullException(nameof(otherPassword));
            }

            return password != null && password.Equals(otherPassword);
        }

        public override bool IsValid(object value) => true;
    }
}