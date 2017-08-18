using Orchard.ContentManagement.Records;

namespace Moov2.Orchard.Featured.Models
{
    public class FeaturedPartRecord : ContentPartVersionRecord
    {
        public virtual bool IsFeatured { get; set; }
        public virtual int Weight { get; set; }
    }
}