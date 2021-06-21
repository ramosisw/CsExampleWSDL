using ClienteWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteWebService.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            return View();
        }

        //
        // POST: /Home/
        [HttpPost]
        public ActionResult Index(LoginModel loginModel) {
            if (ModelState.IsValid) {
                ServiceBasicLogin.BasicLoginSoapClient basicLoginService = new ServiceBasicLogin.BasicLoginSoapClient();
                if (basicLoginService.Login(loginModel.usuario, loginModel.password)) {
                    return RedirectToAction("Message", new { message = basicLoginService.HelloWorld(loginModel.usuario) });
                } else {
                    ModelState.AddModelError("", "Error de Usuario o contraseña");
                }
            }
            return View(loginModel);
        }

        //
        // GET: /Home/Message
        public ActionResult Message(string message) {
            if (!String.IsNullOrEmpty(message)) {
                ViewData["message"] = message;
                return View();
            } else {
                return RedirectToAction("Index");
            }

        }

    }
}
