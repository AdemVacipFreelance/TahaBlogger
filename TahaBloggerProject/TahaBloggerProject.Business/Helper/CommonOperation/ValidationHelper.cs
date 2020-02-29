using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TahaBloggerProject.Business.Helper.CommonOperation
{
  public  static class ValidationHelper
    {
        public const string EmailRegex = @"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$";

        public static bool IsEmail(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            var regex = new Regex(EmailRegex);
            return regex.IsMatch(value);
        }
    }
}
