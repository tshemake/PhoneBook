using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBook.API.Validators
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class PhoneAttribute : ValidationAttribute
    {
        private static string DefaultErrorMessage  => $"{0} телефон не корректный.";
        private string[] Patterns => new[] { @"^(\d{2,3}|\(\d{2,3}\))[ ]?\d{3}[-]?\d{2}[-]?\d{2}$", @"^\d{3}[-]?\d{2}[-]?\d{2}$", @"^\d{2}[-]?\d{2}$" };
        private readonly string _currentErrorMessage;

        public PhoneAttribute(string validationMessage)
        {
            _currentErrorMessage = validationMessage;
        }

        public PhoneAttribute()
            : this(DefaultErrorMessage)
        { }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.CurrentUICulture, DefaultErrorMessage ?? _currentErrorMessage, name);
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            if (!(value is string stringValue)) return false;

            stringValue = stringValue.Trim();
            if (string.IsNullOrWhiteSpace(stringValue)) return true;

            return Patterns.Any(pattern => Regex.IsMatch(stringValue, pattern));
        }
    }
}
