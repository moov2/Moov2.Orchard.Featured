using Orchard.ContentManagement;

namespace Moov2.Orchard.Featured.Models
{
    public class FeaturedPart : ContentPart<FeaturedPartRecord>
    {
        public bool IsFeatured
        {
            get { return Retrieve(x => x.IsFeatured); }
            set { Store(x => x.IsFeatured, value); }
        }

        public int Weight
        {
            get { return Retrieve(x => x.Weight); }
            set { Store(x => x.Weight, value); }
        }
    }
}