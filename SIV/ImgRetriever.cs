using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIV
{
	static class ImgRetriever
	{

		private static readonly string[] FILTERS = {".jpg" ,".bmp",".png",".gif"};

		public static FileInfo[] imagesFileInfoFromfilesFileInfo(FileInfo[] fileInfosToCheck)
		{
			List<FileInfo> listToReturn = new List<FileInfo>();
			foreach (FileInfo fileInfoToCheck in fileInfosToCheck)
			{
				foreach (string extension in FILTERS)
				{
					if (fileInfoToCheck.Extension == extension)
						listToReturn.Add(fileInfoToCheck);
				}
			}
			return listToReturn.ToArray();
		}

	}




}
