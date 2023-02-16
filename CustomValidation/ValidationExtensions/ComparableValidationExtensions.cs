using CustomValidation.ValidationRules;

namespace CustomValidation.ValidationExtensions
{
    public static class ComparableValidationExtensions
    {
        public static ValidationChain<int> AddLesThanValidation(this ValidationChain<int> validationChain,
            int valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<int>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<double> AddLesThanValidation(this ValidationChain<double> validationChain,
            double valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<double>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<float> AddLesThanValidation(this ValidationChain<float> validationChain,
            float valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<float>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<DateTime> AddLesThanValidation(this ValidationChain<DateTime> validationChain,
            DateTime valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<DateTime>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<DateOnly> AddLesThanValidation(this ValidationChain<DateOnly> validationChain,
            DateOnly valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<DateOnly>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<TimeOnly> AddLesThanValidation(this ValidationChain<TimeOnly> validationChain,
            TimeOnly valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<TimeOnly>.AddLesThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<int> AddGreaterThanValidation(this ValidationChain<int> validationChain,
            int valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<int>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<double> AddGreaterThanValidation(this ValidationChain<double> validationChain,
            double valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<double>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<float> AddGreaterThanValidation(this ValidationChain<float> validationChain,
            float valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<float>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<DateTime> AddGreaterThanValidation(this ValidationChain<DateTime> validationChain,
            DateTime valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<DateTime>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<DateOnly> AddGreaterThanValidation(this ValidationChain<DateOnly> validationChain,
            DateOnly valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<DateOnly>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }

        public static ValidationChain<TimeOnly> AddGreaterThanValidation(this ValidationChain<TimeOnly> validationChain,
            TimeOnly valueToCompare)
        {
            validationChain.Rules.Add((property, condition) =>
            ComparableValidationRules<TimeOnly>.AddGreaterThanValidationRule(property, condition));

            validationChain.Conditions.Add(valueToCompare);

            return validationChain;
        }
    }
}
