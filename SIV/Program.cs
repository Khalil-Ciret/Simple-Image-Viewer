using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIV
{
	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main(string [] args)
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//On teste si le fichier est une image
			if (args.Length > 0)
			{
				FileInfo fiForTestingPurposes = new FileInfo(args[0]);
				if (ImgRetriever.isFileAnImage(fiForTestingPurposes))
				Application.Run(new DisplayForm(args[0]));
			}
			else
			Application.Run(new DisplayForm());
		}
	}
}
