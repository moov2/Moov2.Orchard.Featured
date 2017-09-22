using Orchard.UI.Resources;

namespace Moov2.Orchard.Featured
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("FeaturedAdminJs").SetUrl("orchard.featured.admin.min.js", "orchard.featured.admin.js").SetDependencies("JQuery");
        }
    }
}