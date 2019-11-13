using Synthesis;
using Synthesis.FieldTypes;

namespace Sitecore.Foundation.DataAccess.FieldTypes
{
    public class HelixItemReferenceField : ItemReferenceField, IHelixItemReferenceField
    {
        public HelixItemReferenceField(LazyField field, string indexValue) : base(field, indexValue)
        {
        }


        public TTarget GetTarget<TTarget>() where TTarget : class, IStandardTemplateItem
        {
            return Sitecore.Context.Database.GetItem(this.TargetId).As<TTarget>();
        }
    }
}
