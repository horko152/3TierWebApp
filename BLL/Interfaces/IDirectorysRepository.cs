using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
	public interface IDirectorysRepository
	{
		IEnumerable<Directory> GetAllDirectorys(bool includeMaterials = false);

		Directory GetDirectoryById(int directoryId, bool includeMaterials = false);

		void SaveDirectory(Directory directory);

		void DeleteDirectory(Directory directory);
	}
}
