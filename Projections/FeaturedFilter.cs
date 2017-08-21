using Moov2.Orchard.Featured.Models;
using Orchard.ContentManagement;
using Orchard.Events;
using Orchard.Localization;
using System;
using System.Linq;

namespace Moov2.Orchard.Featured.Projections
{
    public interface IFilterProvider : IEventHandler
    {
        void Describe(dynamic describe);
    }

    public class FeaturedFilter : IFilterProvider
    {
        public FeaturedFilter()
        {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public void Describe(dynamic describe)
        {
            describe.For("Featured", T("Featured"), T("Featured"))
                .Element("IsFeatured", T("Is Featured"), T("Featured content items"),
                    (Action<dynamic>)ApplyFilter,
                    (Func<dynamic, LocalizedString>)DisplayFilter,
                    null
                );
        }

        public void ApplyFilter(dynamic context)
        {
            var query = (IHqlQuery)context.Query;
            context.Query = query.Where(x => x.ContentPartRecord<FeaturedPartRecord>(), x => x.Eq("IsFeatured", true));
        }

        public LocalizedString DisplayFilter(dynamic context)
        {
            return T("Is Featured");
        }
    }
}