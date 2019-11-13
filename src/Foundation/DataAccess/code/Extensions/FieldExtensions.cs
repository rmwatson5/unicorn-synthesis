using System.Collections.Specialized;
using Sitecore.Data.Fields;
using Synthesis.FieldTypes;
using Synthesis.FieldTypes.Interfaces;
using FieldType = Synthesis.FieldTypes.FieldType;
using StringDictionary = Sitecore.Collections.StringDictionary;

namespace Sitecore.Foundation.DataAccess.Extensions
{
    public static class FieldExtensions
    {
        public static StringDictionary GetDictionary(this IDictionaryField dict)
        {
            var stringDict = new StringDictionary();
            if (!(dict is FieldType dictField))
            {
                return stringDict;
            }

            var nvl = (NameValueListField)dictField.InnerField;
            foreach (var key in nvl.NameValues.AllKeys)
            {
                stringDict.Add(key, nvl.NameValues[key]);
            }

            return stringDict;
        }

        public static string GetOnValue(this IBooleanField field)
        {
            return field.HasValue && field.Value ? "On" : "Off";
        }
    }
}
