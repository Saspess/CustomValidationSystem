namespace CustomValidation.Contracts
{
    public interface IPropertyValidator<T>
    {
        bool Validate(T property);
    }
}
