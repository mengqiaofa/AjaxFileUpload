using FileUploadAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadAjax.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.FileBase64))
                {
                    byte[] buffer = Convert.FromBase64String(model.FileBase64);
                    string filename = model.FileName;
                    /****************upload file*************/
                }
                return Json(new { Success = true });
            }
            return Json(new { Success = false});
        }
	}
}