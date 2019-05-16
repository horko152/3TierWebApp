using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public class SampleData
	{
		public static void InitData(EFDBContext context)
		{
			if(!context.Directory.Any())
			{
				context.Directory.Add(new Entities.Directory() { Title = "First Directory", Html = "<b>Directory Context</b>" });
				context.Directory.Add(new Entities.Directory() { Title = "Second Directory", Html = "<b>Directory Context</b>" });
				context.Directory.Add(new Entities.Directory() { Title = "Third Directory", Html = "<b>Directory Context</b>" });
				context.SaveChanges();

				context.Material.Add(new Entities.Material() { Title = "First Material", Html = "<i>Material Context</i>", DirectoryId = context.Directory.First().Id });
				context.Material.Add(new Entities.Material() { Title = "Second Material", Html = "<i>Material Context</i>", DirectoryId = context.Directory.First().Id });
				context.Material.Add(new Entities.Material() { Title = "Third Material", Html = "<i>Material Context</i>", DirectoryId = context.Directory.Last().Id });
				context.SaveChanges();

			}
		}
	}
}
