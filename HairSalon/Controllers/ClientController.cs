using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class ClientsConrtoller : Controller
    {
        private readonly HairSalonContext _db;

        public ClientsConrtoller(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (client.StylistId == 0)
            {
                return RedirectToAction("Create");
            }
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
        }
    }
}