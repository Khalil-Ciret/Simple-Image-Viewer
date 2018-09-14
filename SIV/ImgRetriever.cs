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

		public static readonly string[] FILTERS = {".jpg" ,".bmp",".png",".gif"};

		public static FileInfo[] imagesFileInfoFromfilesFileInfo(FileInfo[] fileInfosToCheck)
		{
			List<FileInfo> listToReturn = new List<FileInfo>();
			foreach (FileInfo fileInfoToCheck in fileInfosToCheck)
			{
					if (ImgRetriever.isFileAnImage(fileInfoToCheck))
						listToReturn.Add(fileInfoToCheck);
			}
			return listToReturn.ToArray();
		}

	public static bool isFileAnImage(FileInfo fileToCheck)
	{
		foreach (string extension in ImgRetriever.FILTERS)
		{
			if (fileToCheck.Extension == extension)
				return true;
		}
		return false;
	}

	}




}
