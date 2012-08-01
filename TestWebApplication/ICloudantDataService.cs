using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestWebApplication
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICloudantDataService" in both code and config file together.
	[ServiceContract]
	public interface ICloudantDataService
	{
		[OperationContract]
		string PersistReport( Report report );

		[OperationContract]
		Report GetReport( string id );

		[OperationContract]
		List<Report> GetReportsByType( List<int> types );

		[OperationContract]
		string DoTest();
	}

	public class Report
	{
		public Guid? ID { get; set; }
		public string AccessionNumber { get; set; }
		public int Type { get; set; }
		public string Contents { get; set; }
	}
}
