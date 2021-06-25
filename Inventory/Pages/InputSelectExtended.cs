using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Pages
{

    public class InputSelectExtended<T> : InputSelect<T>
    {
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
        {
            if (typeof(T) == typeof(int))
            {
                if (int.TryParse(value, out var resultInt))
                {
                    result = (T)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }

                result = default;
                validationErrorMessage = "The chosen value is not a valid number.";
                return false;
            }
            if (typeof(T) == typeof(short))
            {
                if (short.TryParse(value, out var resultInt))
                {
                    result = (T)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }

                result = default;
                validationErrorMessage = "The chosen value is not a valid number.";
                return false;
            }

            return base.TryParseValueFromString(value, out result, out validationErrorMessage);
        }
    }
   
}
