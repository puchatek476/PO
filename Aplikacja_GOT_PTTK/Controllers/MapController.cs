using Aplikacja_GOT_PTTK.Data;
using Aplikacja_GOT_PTTK.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Aplikacja_GOT_PTTK.Controllers
{
    public class MapController : Controller
    {
        private readonly ApplicationDbContext _context;

        static List<GeoPointModel> currentPath = new List<GeoPointModel>();
        static int sumPoints = 0;
        

        public MapController(ApplicationDbContext context)
        {
            _context = context;
        }

        public (string, string) getNameAndAlt(string lat, string lng)
        {
            var p = _context.GeoPointModel.ToList().FirstOrDefault(g => g.Latitude == lat && g.Longitude == lng);
            return (p.Name, p.Height);
        }

        public double getDistance(GeoPointModel p1, GeoPointModel p2)
        {
            System.Diagnostics.Debug.WriteLine("p1 " + p1.Latitude + " p2 " + p2.Latitude);
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            
            double rlat1 = Math.PI * Convert.ToDouble(p1.Latitude, provider) / 180;
            double rlat2 = Math.PI * Convert.ToDouble(p2.Latitude, provider) / 180;
            double theta = Convert.ToDouble(p1.Longitude, provider) - Convert.ToDouble(p2.Longitude, provider);
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return dist * 1.609344;
        }

        public int getGOTPointsForPath()
        {

            return 0;
        }

        [HttpPost]
        public void AddPointHelper(string lat, string lng)
        {
            var g = new GeoPointModel();
            (g.Name, g.Height) = getNameAndAlt(lat, lng);
            g.Latitude = lat;
            g.Longitude = lng;
            ViewBag.StartPointName = g.Name;
            if(ViewBag.StartPointName != null)
            {
                ViewBag.EndPointName = g.Name;
            }
            //System.Diagnostics.Debug.WriteLine("Pomyślnie dodano punkt.");
            AddPoint(g);
        }

        [HttpPost]
        public ActionResult AddPoint(GeoPointModel point)
        {
            currentPath.Add(point);

            if (currentPath.Count == 2)
            {
                System.Diagnostics.Debug.WriteLine("Distance [km] " + getDistance(currentPath[0], currentPath[1]));
                double distance = getDistance(currentPath[0], currentPath[1]);
                double height = Math.Abs(Convert.ToDouble(currentPath[0].Height) - Convert.ToDouble(currentPath[1].Height))/100;
                double sumOfPoints = distance * 1 + height * 1;
                System.Diagnostics.Debug.WriteLine("Points: " + sumOfPoints);
                ViewBag.SumPoints = sumOfPoints;
                sumPoints = (int)Math.Round(sumOfPoints);
            }
            return View();
        }

        public ActionResult SavePoints()
        {
            System.Diagnostics.Debug.WriteLine("Save points");
            ViewBag.Pocz = "Punkt początkowy: " + currentPath.First().Name;
            ViewBag.Konc = "Punkt końcowy: " + currentPath.Last().Name;
            ViewBag.Liczba = "Liczba punktów GOT: " + sumPoints;
            ViewBag.Info = "Pomyślnie zapisano trasę.";

            

            PathModel trasa = new PathModel();
            trasa.GOTPoints = sumPoints;
            AccountModel acc = new AccountModel();
            acc.BirthDate = DateTime.Today;
            _context.AccountModel.Add(acc);

            trasa.OwnerAccount = acc;
            trasa.StartDate = DateTime.Now;

            trasa.punktPK = currentPath.Last();
            trasa.punktPP = currentPath.First();

            trasa.punktPocz = currentPath.First().Name;
            trasa.punktKonc = currentPath.Last().Name;

            _context.PathModel.Add(trasa);
            _context.SaveChangesAsync();

            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult Trip()
        {
            var pathList = _context.PathModel.ToList();
            //ViewBag.Paths = _context.PathModel.ToList();
            return View(pathList);
        }

        public async Task<IActionResult> IndexAsync()
        {
            ViewBag.Punkty = await _context.GeoPointModel.ToListAsync();
            return View();
        }
    }
}
