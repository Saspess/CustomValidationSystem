using System.ComponentModel.DataAnnotations;
using CustomValidation.ValidationExtensions;

namespace CustomValidation.Tests.UnitTests
{
    public class StringValidationTests
    {
        [Theory]
        [InlineData("test@gmail.com", true)]
        [InlineData("test@gmail", false)]
        [InlineData("test", false)]
        public void EmailValidationTests(string email, bool isValid)
        {
            var chain = new ValidationChain<string>().AddEmailValidation();
            var validator = new PropertyValidator<string>(chain);

            var result = validator.Validate(email);

            Assert.Equal(result, isValid);
        }

        [Theory]
        [InlineData("+37529123456", true)]
        [InlineData("test123", false)]
        [InlineData("+37529a123456", false)]
        public void PhoneValidationTests(string phone, bool isValid)
        {
            var chain = new ValidationChain<string>().AddPhoneValidation();
            var validator = new PropertyValidator<string>(chain);

            var result = validator.Validate(phone);

            Assert.Equal(result, isValid);
        }

        [Theory]
        [InlineData("1234", true)]
        [InlineData("12345", true)]
        [InlineData("123456", false)]
        public void MaxLengthValidationTests(string property, bool isValid)
        {
            var chain = new ValidationChain<string>().AddMaxLengthValidation(5);
            var validator = new PropertyValidator<string>(chain);

            var result = validator.Validate(property);

            Assert.Equal(result, isValid);
        }

        [Theory]
        [InlineData("1234", true)]
        [InlineData("123", true)]
        [InlineData("12", false)]
        public void MinLengthValidationTests(string property, bool isValid)
        {
            var chain = new ValidationChain<string>().AddNotEmptyValidation().AddMinLengthValidation(3);
            var validator = new PropertyValidator<string>(chain);

            var result = validator.Validate(property);

            Assert.Equal(result, isValid);
        }
    }
}