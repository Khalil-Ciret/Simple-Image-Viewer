using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIV
{
	public partial class DisplayForm : Form
	{
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

			if (imageChoosen.Width > pictureBox1.ClientSize.Width || imageChoosen.Height > pictureBox1.ClientSize.Height)
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			else
				pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.Image = imageChoosen;
			
		}
	}
}
