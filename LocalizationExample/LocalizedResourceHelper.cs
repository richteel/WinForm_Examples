using System;
using System.Resources;

namespace LocalizationExample
{
    public class LocalizedResourceHelper
    {
        public static string GetLocalizedText(object caller, string resourceName, string defaultValue, bool skipChecks = false)
        {
            ResourceManager resourceManager = new ResourceManager(caller.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly());

            if (resourceManager == null || string.IsNullOrEmpty(resourceName))
                return defaultValue;

            string localizedText = resourceManager.GetString(resourceName);

            if (string.IsNullOrEmpty(localizedText))
                return defaultValue;

            return localizedText;
        }

        public static void LocalizeControlText(object caller, object control, string resourceName, bool skipChecks = false)
        {
            ResourceManager resourceManager = new ResourceManager(caller.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly());

            if (!skipChecks)
            {
                if (resourceManager == null || control == null)
                    return;

                if (control == null || control.GetType().GetProperty("Text") == null)
                    return;
            }

            string localizedText = resourceManager.GetString(resourceName);

            if (string.IsNullOrEmpty(localizedText))
                return;

            control.GetType().GetProperty("Text").SetValue(control, localizedText);
        }

        public static void LocalizeControlText(object caller, object control)
        {
            ResourceManager resourceManager = new ResourceManager(caller.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly());

            if (resourceManager == null || control == null)
                return;

            if (control.GetType().GetProperty("Name") == null || control.GetType().GetProperty("Text") == null)
                return;

            string resourceName = control.GetType().GetProperty("Name").GetValue(control).ToString() + ".Text";

            LocalizeControlText(resourceManager, control, resourceName, true);
        }
    }
}
