using CustomValidation.ValidationRules;

namespace CustomValidation.ValidationExtensions
{
    public static class StringValidationExtensions
    {
        private const string EmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

        private const string PhonePattern = @"^\+(?:[0-9]●?){6,14}[0-9]$";

        public static ValidationChain<string> AddRegexValidation(this ValidationChain<string> validationChain,
            string pattern)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddRegexValidationRule(property, condition));

            validationChain.Conditions.Add(pattern);

            return validationChain;
        }

        public static ValidationChain<string> AddEmailValidation(this ValidationChain<string> validationChain)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddRegexValidationRule(property, condition));

            validationChain.Conditions.Add(EmailPattern);

            return validationChain;
        }

        public static ValidationChain<string> AddPhoneValidation(this ValidationChain<string> validationChain)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddRegexValidationRule(property, condition));

            validationChain.Conditions.Add(PhonePattern);

            return validationChain;
        }

        public static ValidationChain<string> AddMaxLengthValidation(this ValidationChain<string> validationChain,
            int maxLength)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddMaxLengthValidationRule(property, condition));

            validationChain.Conditions.Add(Convert.ToString(maxLength));

            return validationChain;
        }

        public static ValidationChain<string> AddMinLengthValidation(this ValidationChain<string> validationChain,
            int minLength)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddMinLengthValidationRule(property, condition));

            validationChain.Conditions.Add(Convert.ToString(minLength));

            return validationChain;
        }

        public static ValidationChain<string> AddNotEmptyValidation(this ValidationChain<string> validationChain)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddNotEqualValidationRule(property, condition));

            validationChain.Conditions.Add(string.Empty);

            return validationChain;
        }

        public static ValidationChain<string> AddNotNullValidation(this ValidationChain<string> validationChain)
        {
            validationChain.Rules.Add((property, condition) =>
            StringValidationRules.AddNotEqualValidationRule(property, condition));

            validationChain.Conditions.Add(null);

            return validationChain;
        }
    }
}
