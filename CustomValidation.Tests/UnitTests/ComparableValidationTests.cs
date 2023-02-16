using CustomValidation.ValidationExtensions;

namespace CustomValidation.Tests.UnitTests
{
    public class ComparableValidationTests
    {

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        public void LesThanValidationTests(int property, bool isValid)
        {
            var chain = new ValidationChain<int>().AddLesThanValidation(2);
            var validator = new PropertyValidator<int>(chain);

            var result = validator.Validate(property);

            Assert.Equal(result, isValid);
        }

        [Theory]
        [InlineData(3, false)]
        [InlineData(2, false)]
        [InlineData(1, true)]
        public void GreaterThanValidationTests(int property, bool isValid)
        {
            var chain = new ValidationChain<int>().AddLesThanValidation(2);
            var validator = new PropertyValidator<int>(chain);

            var result = validator.Validate(property);

            Assert.Equal(result, isValid);
        }
    }
}