using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class Service1 : IService1
	{
		public void FormData(Stream stream)
		{
			StreamContent streamContent = new StreamContent(stream);
			streamContent.Headers.ContentType = MediaTypeHeaderValue.Parse(WebOperationContext.Current.IncomingRequest.ContentType);
			var task = Task.Run(() => streamContent.ReadAsMultipartAsync());
			task.Wait();
			var httpContents = from contents in task.Result.Contents where !string.IsNullOrEmpty(contents.Headers.ContentDisposition.FileName) select contents;
			Debug.WriteLine(httpContents.Skip(1).First().Headers.ContentDisposition);
		}

		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}
	}
}
