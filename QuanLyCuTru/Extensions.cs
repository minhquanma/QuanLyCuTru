using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DateTimeExt
{
    static class Extensions
    {
        public static string ToStringSafe(this DateTime? t)
        {
            return t.HasValue ? t.Value.ToString("dd/MM/yyyy") : String.Empty;
        }
    }
}