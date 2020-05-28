using System.Linq;
using System.Web.Http;
using MvmIcommandAPI.Models;

using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace MvmIcommandAPI.Controllers
{
    public class UsersController : ApiController
    {
        public object Session { get; private set; }

        [HttpPost]

            public ActionResult Validate(string phone_num)

            {

                using (var db = new UserContext())

                {

                    var user = db.Users.First(u => u.PhoneNumber == phone_num);



                    if (user != null)

                    {

                        Session["PhoneNumber"] = phone_num;

                        Session["Token"] = user.SendToken();

                        return Json(new { success = true });

                    }

                    else

                    {

                        return Json(new { success = false });

                    }

                }

            }



            [HttpPost]

            public ActionResult Auth(string token)

            {

                using (var db = new UserContext())

                {

                    string number = Session["PhoneNumber"].ToString();



                    var user = db.Users.First(u => u.PhoneNumber == number);



                    if (user != null && token == Session["Token"].ToString())

                    {

                        Session.Remove("Token");

                        Session.Remove("PhoneNumber");

                        return Json(new { success = true });

                    }

                    else

                    {

                        return Json(new { success = false });

                    }

                }

            }
     }
}