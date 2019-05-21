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
using PresentationLayer.Models;
using PresentationLayer;

namespace _3TierWebApp.Controllers
{
	public class HomeController : Controller
	{
		//private EFDBContext _context;
		//private IDirectorysRepository _dirRep;
		private DataManager _datamanager;
		private ServicesManager _servicesmanager;
		public HomeController(/*EFDBContext context, IDirectorysRepository dirRep, */DataManager dataManager)
		{
			//_context = context;
			//dirRep = _dirRep;
			_datamanager = dataManager;
			_servicesmanager = new ServicesManager(_datamanager);
		}

		public IActionResult Index()
		{
			HelloModel _model = new HelloModel() { HelloMessage = "Hi Igor!" };
			//List<Directory> _dirs = _context.Directory.Include(x=>x.Materials).ToList();
			//List<Directory> _dirs = _dirRep.GetAllDirectorys().ToList();
			//List<Directory> _dirs = _datamanager.Directorys.GetAllDirectorys(true).ToList();
			List<DirectoryViewModel> _dirs = _servicesmanager.Directorys.GetDirectoryesList();

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

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
