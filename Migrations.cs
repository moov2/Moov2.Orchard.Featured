using Moov2.Orchard.Featured.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.Localization;
using Orchard.Projections.Models;

namespace Moov2.Orchard.Featured
{
    public class Migrations : DataMigrationImpl
    {
        #region Dependencies

        private readonly IRepository<MemberBindingRecord> _memberBindingRepository;

        public Localizer T { get; set; }

        #endregion

        #region Constructor

        public Migrations(IRepository<MemberBindingRecord> memberBindingRepository)
        {
            _memberBindingRepository = memberBindingRepository;
            T = NullLocalizer.Instance;
        }

        #endregion

        #region Implementation

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

            _memberBindingRepository.Create(new MemberBindingRecord
            {
                Type = typeof(FeaturedPartRecord).FullName,
                Member = "Weight",
                DisplayName = T("Featured Weight").Text,
                Description = T("Weight given to featured content item.").Text
            });

            return 2;
        }
        
        public int UpdateFrom1()
        {
            _memberBindingRepository.Create(new MemberBindingRecord
            {
                Type = typeof(FeaturedPartRecord).FullName,
                Member = "Weight",
                DisplayName = T("Featured Weight").Text,
                Description = T("Weight given to featured content item.").Text
            });

            return 2;
        }

        #endregion
    }
}