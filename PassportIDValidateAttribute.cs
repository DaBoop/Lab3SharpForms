using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2SharpForms
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    class PassportIDValidateAttribute : ValidationAttribute
    {
        Regex mask = new Regex(@"[A-Z]{2}\d{7}");

        public PassportIDValidateAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public PassportIDValidateAttribute()
        {

        }

        public override bool IsValid(object value)
        {
            var passportId = (String)value;
            bool result = false;
            if (mask.IsMatch(passportId))
            {
                result = true;
            }
            return result;
        }

    }
}
