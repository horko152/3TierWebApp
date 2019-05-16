using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _3TierWebApp.Models;
using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using BLL.Interfaces;
using BLL;

namespace _3TierWebApp.Controllers
{
	public class HomeController : Controller
	{
		private EFDBContext _context;
		private IDirectorysRepository _dirRep;
		private DataManager _datamanager;
		public HomeController(EFDBContext context, IDirectorysRepository dirRep, DataManager datamanager)
		{
			 _context = context;
			_dirRep = dirRep;
			_datamanager = datamanager;
		}
		public IActionResult Index()
		{
			IndexModel _model = new IndexModel() { HelloMessage = "Hi Igor" };
			//List<Directory> _dirs = _context.Directory.Include(x=>x.Materials).ToList();
			//List<Directory> _dirs = _dirRep.GetAllDirectorys().ToList();
			List<Directory> _dirs = _datamanager.Directorys.GetAllDirectorys(true).ToList();
			return View(_dirs);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
