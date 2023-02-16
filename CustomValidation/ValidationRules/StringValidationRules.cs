using System.Text.RegularExpressions;

namespace CustomValidation.ValidationRules
{
    public static class StringValidationRules
    {
        public static bool AddMinLengthValidationRule(string property, string condition)
        {
            var minLength = Convert.ToInt32(condition);

            if (property.Length < minLength)
            {
                return false;
            }

            return true;
        }

        public static bool AddMaxLengthValidationRule(string property, string condition)
        {
            var maxLength = Convert.ToInt32(condition);

            if (property.Length > maxLength)
            {
                return false;
            }

            return true;
        }

        public static bool AddRegexValidationRule(string property, string pattern)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(property))
            {
                return false;
            }

            return true;
        }

        public static bool AddEqualValidationRule(string property, string condition)
        {
            if (property != condition)
            {
                return false;
            }

            return true;
        }

        public static bool AddNotEqualValidationRule(string property, string condition)
        {
            if (property == condition)
            {
                return false;
            }

            return true;
        }
    }
}
