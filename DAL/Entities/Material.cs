using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
	public class Material : Page
	{
		public int DirectoryId { get; set; } //Зовнішній ключ
		public Directory Directory { get; set; } //Навігаційна властивість

	}
}
