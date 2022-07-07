using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace billwerkTestTask.Helpers
{
    public static class ConfigHelper
    {
        private static readonly string _settings = "//Resources//settings.json";

        public static string GetConfigProperties(string key) =>
            GetSpecificProperties(_settings, key);

        private static string GetSpecificProperties(string propertyPath, string key)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            JObject jsonObject = JObject.Parse(File.ReadAllText(domain.BaseDirectory +
                propertyPath));
            string jsonString = jsonObject.ToString(Newtonsoft.Json.Formatting.None);

            return JObject.Parse(jsonString)[key].ToString();
        }
    }
}