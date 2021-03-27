using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Электронная_библиотека
{
    class MyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                Regex reg = new Regex(@"[0 - 9]{ 2 }.[0 - 9]{ 2}.[0 - 9]{ 4}");
                string Number = value.ToString();
                if (reg.IsMatch(Number))
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Неверный формат даты";
                }
            }
            return false;
        }
    }
}
