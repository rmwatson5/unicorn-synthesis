using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Sitecore.Collections;
using Sitecore.Data.Items;

namespace Sitecore.Foundation.DataAccess.Extensions
{
    public static class SitecoreExtensions
    {
        public static readonly Dictionary<string, string> UrlReplacements = new Dictionary<string, string>
        {
            {"\\&{1,}", string.Empty},
            {"\\s{1,}", "-"},
            {"(\\-{1,}(\\s*\\-*)*)", "-"}
        };

        public static string Nameify(this string name) =>
            string.IsNullOrWhiteSpace(name) ? string.Empty : ItemUtil.ProposeValidItemName(name);

        public static string SitecoreNameify(this string name)
        {
            name = Nameify(name).Trim().ToLowerInvariant();
            name = UrlReplacements.Aggregate(name, (s, pair) => Regex.Replace(s, pair.Key, pair.Value));
            return name;
        }

        public static void TryAdd(this StringDictionary dict, string key, string value)
        {
            if (dict != null && !dict.ContainsKey(key) && !string.IsNullOrWhiteSpace(value))
            {
                dict.Add(key, value);
            }
        }
    }
}
