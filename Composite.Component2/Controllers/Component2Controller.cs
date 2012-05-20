using System;
using System.Web.Mvc;
using Composite.Component2.Properties;

namespace Composite.Component2.Controllers
{
    public class Component2Controller : Controller
    {
        public ActionResult Script()
        {
            return JavaScript(Resources.Component2);
        }

        public ActionResult GetPersons(Guid[] ids)
        {
            return Json(new
            {
                persons = new[]{
                                new {
                                  id = Guid.NewGuid(),
                                  name = "Person 1"
                                },
                                new {
                                  id = Guid.NewGuid(),
                                  name = "Person 2"
                                },
                                new {
                                  id = Guid.NewGuid(),
                                  name = "Person 3"
                                }
                }
            });
        }
    }
}