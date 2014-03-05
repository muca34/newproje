 

using System.Linq;
using System.Web.Mvc;
using Komiks.Core.Domain.Taglar;
using Komiks.Services.Taglar;
using Komiks.Web.Models.Customers;


namespace Komiks.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
      CustomerModel _model= new CustomerModel();
        Tags kTags=new Tags();
      private ITagService service;

      public HomeController(ITagService srv)
      {
          service = srv;
      }

     
      
        public ActionResult Index()
        {
            kTags.TagId = 11;
            kTags.TagTitle = "Gençlerbirliği";
            kTags.TagDelete = true;
            service.UpdateTag(kTags);
            var taglar = service.GetTags();
            _model.Tagses = taglar;


            return View(_model);
        }

    }
}
