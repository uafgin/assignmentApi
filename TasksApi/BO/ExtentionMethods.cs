using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TasksApi
{
    public static class ExtentionMethods
    {
        public static string readFile(this string obj)
        {
            if (!File.Exists(obj))
            {
                return null;
            }
            using (var sr = new StreamReader(obj))
            {
                return sr.ReadToEnd();
            }
        }

        public static T Deserialize<T>(this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }

        public static string Serialize<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
