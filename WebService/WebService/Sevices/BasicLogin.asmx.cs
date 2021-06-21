using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService.Sevices {
    /// <summary>
    /// Summary description for BasicLogin
    /// </summary>
    [WebService(Namespace = "http://localhost/WebService", Name = "BasicLogin", Description = "BasicLogin")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BasicLogin : System.Web.Services.WebService {

        [WebMethod]
        public string HelloWorld(string usuario) {
            return string.Format("Hello World {0}", usuario);
        }
        [WebMethod]
        public bool Login(string usuario, string password) {
            string[] dataUsers = { "bar:usuario", "foo:123", "admin:admin", "usuario:12345" };
            foreach (string user in dataUsers) {
                if (usuario == user.Split(':')[0] && password == user.Split(':')[1]) {
                    return true;
                } else {
                    return false;
                }
            }
            return false;
        }
    }
}
