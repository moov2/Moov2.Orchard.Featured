using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Moov2.Orchard.Featured
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("FeaturedPartRecord",
                table => table
                    .ContentPartVersionRecord()
                    .Column<bool>("IsFeatured")
                    .Column<int>("Weight")
                );

            ContentDefinitionManager.AlterPartDefinition("FeaturedPart", builder => builder
                .Attachable()
                .WithDescription("Flag content as featured."));
            
            return 1;
        }
    }
}