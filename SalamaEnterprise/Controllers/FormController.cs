using SalamaEnterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalamaEnterprise.Controllers
{

    public class FormController : Controller
    {
        FormFields formFld = new Models.FormFields();
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CarDetails()
        {
            return View();
        }

        public ActionResult CarInformation()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult dropDownFiller(string key, string param)
        {
            try
            {
                return Json(formFld.dropDownFiller(key, param), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                if (Request.IsAjaxRequest())
                {
                    Response.StatusCode = 500;
                    return Json("Error in " + ex.Message.ToString(), JsonRequestBehavior.AllowGet);
                }
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}