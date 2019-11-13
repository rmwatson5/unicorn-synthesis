using Synthesis;
using Synthesis.FieldTypes.Interfaces;

namespace Sitecore.Foundation.DataAccess.FieldTypes
{
    public interface IHelixItemReferenceField : IItemReferenceField
    {
        TTarget GetTarget<TTarget>() where TTarget : class, IStandardTemplateItem;
    }
}
