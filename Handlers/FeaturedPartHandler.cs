using Moov2.Orchard.Featured.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace Moov2.Orchard.Featured.Handlers
{
    public class FeaturedPartHandler : ContentHandler
    {
        public FeaturedPartHandler(IRepository<FeaturedPartRecord> featuredRepository)
        {
            Filters.Add(StorageFilter.For(featuredRepository));
        }
    }
}