using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using RedBranch.Hammock;
using RedBranch.Hammock.Design;

namespace TestWebApplication
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CloudantDataService" in code, svc and config file together.
	public class CloudantDataService : ICloudantDataService
	{
		public CloudantDataService()
		{
			var url = ConfigurationManager.AppSettings.Get( "CLOUDANT_URL" );
			var connection = new Connection( new Uri( url ) );
			if ( !connection.ListDatabases().Contains( "reports" ) )
			{
				connection.CreateDatabase( "reports" );
			}
			_repository = new Repository<Report>( connection.CreateSession( "reports" ) );
		}

		public string PersistReport( Report report )
		{
			return _repository.Save( report ).Id;
		}

		public Report GetReport( string id )
		{
			return _repository.Get( id );
		}

		public List<Report> GetReportsByType( List<int> types )
		{
			throw new NotImplementedException();
		}

		public string DoTest()
		{
			throw new NotImplementedException();
		}

		private Repository<Report> _repository;
	}
}
