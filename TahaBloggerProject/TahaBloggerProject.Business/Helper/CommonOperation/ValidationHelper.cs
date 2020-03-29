using System.Text.RegularExpressions;

namespace TahaBloggerProject.Business.Helper.CommonOperation
{
    public static class ValidationHelper
    {
        private const string EmailRegex = @"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$";

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