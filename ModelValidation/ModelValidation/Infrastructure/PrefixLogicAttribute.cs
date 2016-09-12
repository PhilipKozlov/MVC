using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ModelValidation.Infrastructure
{
    public class PrefixLogicAttribute : StringLengthAttribute
    {
        public PrefixLogicAttribute(int maximumLenght) : base(maximumLenght) { }

        public override bool IsValid(object value)
        {
            var input = value as string;
            return input != null && Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
    }
}