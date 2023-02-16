namespace CustomValidation.ValidationRules
{
    public static class ComparableValidationRules<T> where T : IComparable<T>
    {
        public static bool AddLesThanValidationRule(T property, T valueToCompare)
        {
            if (property.CompareTo(valueToCompare) >= 0)
            {
                return false;
            }

            return true;
        }

        public static bool AddGreaterThanValidationRule(T property, T valueToCompare)
        {
            if (property.CompareTo(valueToCompare) <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
