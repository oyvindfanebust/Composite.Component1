using System;
using System.Web.Mvc;
using Composite.Component1.Properties;

namespace Composite.Component1.Controllers
{
    public class Component1Controller : Controller
    {
        public ActionResult Script()
        {
            return JavaScript(Resources.Component1);
        }

        public ActionResult GetThingOwners(Guid id)
        {
            return Json(new
            {
                id = id,
                thingOwners = new[]{ 
                                new {
                                  id = Guid.NewGuid(),
                                  numberOfThings = 1
                                },
                                new {
                                  id = Guid.NewGuid(),
                                  numberOfThings = 2
                                },
                                new {
                                  id = Guid.NewGuid(),
                                  numberOfThings = 3
                                }
                }
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateThingOwners(dynamic thingOwners)
        {
            return new HttpStatusCodeResult(200);
        }
    }
}