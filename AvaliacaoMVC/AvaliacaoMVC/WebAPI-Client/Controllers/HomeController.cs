using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI_Client.Models;

namespace WebAPI_Client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllData()
        {
            try
            {
                var response = JsonConvert.DeserializeObject<List<Product>>(new WebClient().DownloadString("http://localhost:59833/api/Values"));

                if (response.Count > 0)
                {
                    response = response.OrderBy(p => p.Value).Take(10).ToList();
                }

                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (WebException)
            {
                Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
                return Json("Não foi possível a comunicação com o serviço de dados. Entre em contato com o suporte.", JsonRequestBehavior.AllowGet);
            }


        }
    }
}