using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SIV
{
	public partial class DisplayForm : Form
	{

		private const string FILTERS = " *.jpg;*.bmp;*.png;*.gif";

		private string nextFilename;
		private string prevFilename;
		private string dirName;

		public DisplayForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void chooseButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.loadImageFromFileName(openFileDialog1.FileName);
			}
		}

		private void loadImageFromFileName(string fileName)
		{
			Image imageChoosen = Image.FromFile(openFileDialog1.FileName);
			this.dirName = Path.GetDirectoryName(openFileDialog1.FileName);

			if (imageChoosen.Width > pictureBox1.ClientSize.Width || imageChoosen.Height > pictureBox1.ClientSize.Height)
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			else
				pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.Image = imageChoosen;
			this.loadPreviousAndNextFileNames(fileName);
		}

		private void loadPreviousAndNextFileNames(string fileName)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(this.dirName);
			int i = 0;
			FileInfo[] cp = dirInfo.GetFiles(FILTERS); //todo : check pourquoi c'est zéro
			foreach (FileInfo fi in cp)
			{
				if (fi.Name == fileName)
				{

					if (i == 0)
					{
						this.nextFilename = cp[i + 1].Name;
						this.prevFilename = cp[cp.Length - 1].Name;
					}
					else if (i == cp.Length)
					{
						this.nextFilename = cp[0].Name;
						this.prevFilename = cp[cp.Length - 2].Name;
					}
					else
					{
						this.nextFilename = cp[i + 1].Name;
						this.prevFilename = cp[i - 1].Name;
					}
				}
				i++;
			}
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			if (this.nextFilename != null)
			{
				this.loadImageFromFileName(this.nextFilename);
			}

		}
	}
			
}
