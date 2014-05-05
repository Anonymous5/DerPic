using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DerPic.Properties;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DerPic
{
	public partial class MainForm : Form
	{
		public ImageInformationList ImageList;
		void GetImageList()
		{
			var client = new WebClient();
			var stream = client.OpenRead("http://derpibooru.org/images.json?perpage=10");
			var reader = new StreamReader(stream);
			string text = reader.ReadToEnd();
			stream.Close();
			byte[] byteArray = Encoding.UTF8.GetBytes(text);
			var stream1 = new MemoryStream(byteArray);
			var serializer = new DataContractJsonSerializer(typeof(ImageInformationList));
			ImageList = serializer.ReadObject(stream1) as ImageInformationList;
			stream1.Close();
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (DerPicSettings.Default.WindowSize != null)
				Size = DerPicSettings.Default.WindowSize;
			else
				Size = new Size(800, 600);
			WindowState = DerPicSettings.Default.WindowState;

			GetImageList();
			var lst = new List<string>();
			foreach (var element in ImageList.List)
			{
				listBox1.Items.Add("http:" + element.Image);
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DerPicSettings.Default.WindowState = WindowState;
			if (this.WindowState == FormWindowState.Normal)
				DerPicSettings.Default.WindowSize = Size;
			else
				DerPicSettings.Default.WindowSize = RestoreBounds.Size;
			DerPicSettings.Default.Save();
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			var item = string.Empty;
			if (listBox1.SelectedItem == null) return;
			if (listBox1.SelectedItem.GetType() == typeof(string))
				item = listBox1.SelectedItem.ToString();
			if (!string.IsNullOrEmpty(item))
			{
				var viewer = new ViewerForm();
				viewer.ImgURL = item;
				viewer.ShowDialog();
			}
		}
	}
}
