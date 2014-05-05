using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DerPic
{
	[DataContract]
	public class ImageInformation
	{
		[DataMember(Name = "id_number")]
		public int Id { get; set; }
		[DataMember(Name = "file_name")]
		public string FileName { get; set; }
		[DataMember(Name = "image")]
		public string Image { get; set; }
		[DataMember(Name = "tags")]
		private string _tags { get; set; }
		public List<string> Tags { get { return _tags.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList(); } set { Tags = value; } }
		[DataMember(Name = "width")]
		public int Width { get; set; }
		[DataMember(Name = "height")]
		public int Height { get; set; }
	}
}
