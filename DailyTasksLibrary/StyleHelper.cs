using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary
{
    public static class StyleHelper
    {
        public static bool IsSystemDarkTheme()
        {
            const string userRoot = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Theme\Personalize";
            object? value = Registry.GetValue(userRoot, "AppsUseLightTheme", null);
            if (value is int intValue)
            {
                return intValue == 0;
            }
            return false;
        }
    }
}
