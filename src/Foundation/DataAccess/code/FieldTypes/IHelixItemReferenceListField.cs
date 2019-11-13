using System.Collections.Generic;
using Synthesis;

namespace Sitecore.Foundation.DataAccess.FieldTypes
{
    public interface IHelixItemReferenceListField : Synthesis.FieldTypes.Interfaces.IItemReferenceListField
    {
        IEnumerable<TItem> GetItems<TItem>() where TItem : class, IStandardTemplateItem;
    }
}
