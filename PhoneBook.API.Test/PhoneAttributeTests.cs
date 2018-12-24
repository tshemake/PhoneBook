using System;
using System.Collections;
using System.Collections.Generic;
using PhoneBook.API.Validators;
using Xunit;

namespace PhoneBook.API.Test
{
    public class PhoneAttributeTests
    {
        [Fact]
        public static void Validate_successful_for_valid_phone_numbers()
        {
            var attribute = new PhoneAttribute();
            Assert.True(attribute.IsValid("(999) 999-99-99"));
            Assert.True(attribute.IsValid("(999) 9999999"));
            Assert.True(attribute.IsValid("(999)9999999"));
            Assert.True(attribute.IsValid("9999999999"));
            Assert.True(attribute.IsValid("999-99-99"));
            Assert.True(attribute.IsValid("999-9999"));
            Assert.True(attribute.IsValid("99999-99"));
            Assert.True(attribute.IsValid("9999999"));
            Assert.True(attribute.IsValid("99-99"));
            Assert.True(attribute.IsValid("9999"));
        }

        [Fact]
        public static void Validate_successful_for_null_value()
        {
            var attribute = new PhoneAttribute();
            Assert.True(attribute.IsValid(null));
        }

        [Fact]
        public static void Validate_successful_for_empty_value()
        {
            var attribute = new PhoneAttribute();
            Assert.True(attribute.IsValid(string.Empty));
        }

        [Fact]
        public static void Validate_invalid_phone_numbers()
        {
            var attribute = new PhoneAttribute();
            Assert.False(attribute.IsValid("(9999) 999-99-99"));
            Assert.False(attribute.IsValid("(999) 9999-99-99"));
            Assert.False(attribute.IsValid("(999) 999-999-99"));
            Assert.False(attribute.IsValid("(999) 999-99-999"));
            Assert.False(attribute.IsValid("9999-99-99"));
            Assert.False(attribute.IsValid("999-999-99"));
            Assert.False(attribute.IsValid("999-99-999"));
            Assert.False(attribute.IsValid("999-99"));
            Assert.False(attribute.IsValid("99-999"));
        }
    }
}
