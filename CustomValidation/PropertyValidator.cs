using CustomValidation.Contracts;

namespace CustomValidation
{
    public class PropertyValidator<T> : IPropertyValidator<T>
    {
        public ValidationChain<T> Chain { get; set; }

        public PropertyValidator(ValidationChain<T> chain)
        {
            Chain = chain;
        }

        public bool Validate(T property)
        {
            for (var i = 0; i < Chain.Rules.Count; i++)
            {
                var result = Chain.Rules[i].Invoke(property, Chain.Conditions[i]);

                if(result == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
