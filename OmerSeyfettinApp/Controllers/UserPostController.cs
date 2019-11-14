using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using OmerSeyfettinApp.Models;
using DevExpress.XtraRichEdit;

namespace OmerSeyfettinApp.Controllers
{
    public class UserPostController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult RichEditPartial()
        {
            if (User.Identity.GetUserId() is null)
            {
                //  return View("/Views/Account/Login.cshtml");
                return View("Error");
            }
          else  
        {
                var model = new RichEditData()
                {
                    DocumentId = User.Identity.GetUserId(),
                    DocumentFormat = DocumentFormat.Rtf,
                    Document = DataHelper.GetDocument()
                };
                return PartialView(model);
            }
        }
    
    }
}