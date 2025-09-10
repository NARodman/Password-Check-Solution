

using System.Security.Cryptography;

namespace PasswordCheck
{



    public class Password

    /// <summary>
        /// Checks the strength of a given password.
        /// Evaluates based on presence of uppercase, lowercase, digits, symbols,
        /// and a minimum length of 8 characters.
        /// </summary>
        /// <param name="password">The password string to evaluate.</param>
        /// <returns>
        /// "INELIGABLE" if password field is empty or less than 8 characters,
        /// "WEAK" if only one category is met,
        /// "MEDIUM" if two or three categories are met,
        /// "STRONG" if all categories are met.
        /// </returns>
    {
        public string StrengthCheck(string password)
        {
            if (string.IsNullOrEmpty(password))
                return "INELIGABLE";

            if (password.Length < 8)
                    return "INELIGABLE";

            bool hasUpper = false;
            bool haslower = false;
            bool hasDigit = false;
            bool hasSymbol = false;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                else if (char.IsLower(ch)) haslower = true;
                else if (char.IsDigit(ch)) hasDigit = true;
                else hasSymbol = true;
            }

            int criteriaMet = 0;
            if (hasUpper) criteriaMet++;
            if (haslower) criteriaMet++;
            if (hasDigit) criteriaMet++;
            if (hasSymbol) criteriaMet++;

            if (criteriaMet == 0)
                return "INELIGABLE";
            else if (criteriaMet == 1)
                return "WEAK";
            else if (criteriaMet == 2 || criteriaMet == 3)
                return "MEDIUM";
            else
                return "STRONG";

                


        }

    }
}