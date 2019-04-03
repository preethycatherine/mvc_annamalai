using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agency.Repository.Database;

namespace agency.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult Index()
        {
            return View(new agency.Models.view_model.md_customer());
        }

        [HttpPost]
        public ActionResult create(agency.Models.view_model.md_customer customer)
        {
            agencyEF db = new agencyEF();
            db.tblcustomers.Add(new tblcustomer() {
                active=true,
                name=customer.name,
                phone=customer.phone,
                address1=customer.address1,
                address2=customer.address2,
                address3=customer.address3,
                state=customer.state,
                district=customer.district,
                pincode=customer.pincode,
                createdon=customer.createdon
                
            });
            return null;
        }
    }
}