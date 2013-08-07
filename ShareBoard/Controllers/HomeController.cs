using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ShareBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public ContentResult Upload(HttpPostedFileBase file)
        {
            var filename = Path.GetFileName(file.FileName);
            var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/uploads"), filename);
            file.SaveAs(path);
        
            return new ContentResult
            {
                ContentType = "text/plain",
                Content = filename,
                ContentEncoding = Encoding.UTF8
            };
        }
    }
}
