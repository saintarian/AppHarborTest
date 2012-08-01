using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RedBranch.Hammock;
using RedBranch.Hammock.Design;

namespace TestWebApplication
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load( object sender, EventArgs e )
		{
			var url = ConfigurationManager.AppSettings.Get( "CLOUDANT_URL" );
			_label.Text = url;
			/*
			var connection = new Connection( new Uri( url ) );
			if ( !connection.ListDatabases().Contains( "reports" ) )
			{
				connection.CreateDatabase( "reports" );
			}
			var repository = new Repository<Report>( connection.CreateSession( "reports" ) );
			var report = new Report { ID = Guid.NewGuid(), Type = 1, AccessionNumber = "123", Contents = "abcd" };
			System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
			watch.Reset();
			watch.Start();
			var id = repository.Save( report ).Id;
			var retrievedReport = repository.Get( id );
			watch.Stop();
			if ( retrievedReport.ID == report.ID && retrievedReport.Type == report.Type && retrievedReport.AccessionNumber == report.AccessionNumber && retrievedReport.Contents == report.Contents )
			{
				_label.Text = watch.ElapsedMilliseconds.ToString();
			}
			else
			{
				_label.Text = "Error";
			}
			*/
		}
	}
}
