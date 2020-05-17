﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KlingenRestaurant
{
    class PhoneNumberValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string number = value as string;
            if (Regex.Match(number, @"^(\+375[0-9]{9})$").Success == true)
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false,"Некорректный номер");
        }
    }

}
