using Moov2.Orchard.Featured.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace Moov2.Orchard.Featured.Drivers
{
    public class FeaturedPartDriver : ContentPartDriver<FeaturedPart>
    {
        #region Constants

        private const string TemplateName = "Parts.Featured.FeaturedPart";

        #endregion

        #region Dependencies

        public Localizer T { get; set; }

        #endregion

        #region Overrides

        protected override string Prefix
        {
            get { return "Featured"; }
        }

        #endregion

        #region Editor

        protected override DriverResult Editor(FeaturedPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_Featured_Edit",
                () => shapeHelper.EditorTemplate(TemplateName: TemplateName, Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(FeaturedPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);

            return Editor(part, shapeHelper);
        }

        #endregion

        #region Import/Export

        protected override void Importing(FeaturedPart part, ImportContentContext context)
        {
            // Don't do anything if the tag is not specified.
            if (context.Data.Element(part.PartDefinition.Name) == null)
                return;

            context.ImportAttribute(part.PartDefinition.Name, "IsFeatured", isFeatured =>  part.IsFeatured = bool.Parse(isFeatured));
            context.ImportAttribute(part.PartDefinition.Name, "Weight", weight => part.Weight = int.Parse(weight));
        }

        protected override void Exporting(FeaturedPart part, ExportContentContext context)
        {
            context.Element(part.PartDefinition.Name).SetAttributeValue("IsFeatured", part.IsFeatured);
            context.Element(part.PartDefinition.Name).SetAttributeValue("Weight", part.Weight);
        }

        #endregion
    }
}