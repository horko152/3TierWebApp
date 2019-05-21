using BLL;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer
{
	public class ServicesManager
	{
		DataManager _dataManager;
		private DirectoryService _directoryService;
		private MaterialService _materialService;

		public ServicesManager(
			DataManager dataManager
			)
		{
			_dataManager = dataManager;
			_directoryService = new DirectoryService(_dataManager);
			_materialService = new MaterialService(_dataManager);
		}
		public DirectoryService Directorys { get { return _directoryService; } }
		public MaterialService Materials { get { return _materialService; } }
	}
}
