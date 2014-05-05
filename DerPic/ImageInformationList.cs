using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DerPic
{
	[DataContract]
	public class ImageInformationList
	{
		[DataMember(Name = "images")]
		public List<ImageInformation> List { get; set; }
	}
}
