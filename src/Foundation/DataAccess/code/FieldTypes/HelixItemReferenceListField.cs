using System.Collections.Generic;
using System.Linq;
using Synthesis;
using Synthesis.FieldTypes;

namespace Sitecore.Foundation.DataAccess.FieldTypes
{
    public class HelixItemReferenceListField : ItemReferenceListField, IHelixItemReferenceListField
    {
        public HelixItemReferenceListField(LazyField field, string indexValue) : base(field, indexValue)
        {
        }

        public IEnumerable<TItem> GetItems<TItem>() where TItem : class, IStandardTemplateItem
        {
            return this.TargetIds.Select(tid => Context.Database.GetItem(tid)?.As<TItem>()).Where(i => i != null);
        }
    }
}
