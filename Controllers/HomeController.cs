using Moov2.Orchard.Featured.Models;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Localization;
using Orchard.UI.Notify;
using System.Web.Mvc;

namespace Moov2.Orchard.Featured.Controllers
{
    public class HomeController : Controller
    {
        #region Constants

        private const int DefaultWeight = 15;

        #endregion

        #region Dependencies

        private readonly IOrchardServices _orchardServices;

        public Localizer T;

        #endregion

        #region PrivateProperties

        private string ReturnUrl
        {
            get
            {
                return !string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]) ? Request.QueryString["ReturnUrl"] : "/Admin/Contents/List";
            }
        }

        #endregion

        #region Constructor

        public HomeController(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;
            T = NullLocalizer.Instance;
        }

        #endregion

        #region Actions

        [HttpGet]
        [Authorize]
        public ActionResult Toggle(int id)
        {
            var content = _orchardServices.ContentManager.Get(id);

            if (content == null || content.As<FeaturedPart>() == null)
                return HttpNotFound();

            content.As<FeaturedPart>().IsFeatured = !content.As<FeaturedPart>().IsFeatured;

            if (content.As<FeaturedPart>().IsFeatured)
                content.As<FeaturedPart>().Weight = DefaultWeight;

            _orchardServices.Notifier.Add(NotifyType.Information, T(content.As<FeaturedPart>().IsFeatured ? "Successfully set {0} as featured." : "{0} is no longer featured.", content.As<ITitleAspect>().Title));
            return Redirect(ReturnUrl);
        }

        #endregion
    }
}