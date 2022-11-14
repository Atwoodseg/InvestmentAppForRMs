using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace RM_APP
{
	internal class DBConnectionClass
	{
		//attributes

		//private object of the class itself
		private static DBConnectionClass _instance;

		//connection string 
		private string _connStr;

		//connection to the DB
		private SqlConnection _connToDB;

		//Constructors
		private DBConnectionClass()
		{
			//IMPORTANT! add the DB connection string
			//_connStr = RM_Forms_app.Properties.Settings.Default.DBConnectionString;
		}

		///
		///methods
		///
		/**
		 *a static method that creates an unique object of the class itself
		 */
		public static DBConnectionClass getInstanceOfDBConnection()
		{
			if (_instance == null)
			{
				_instance = new DBConnectionClass();
			}
			return _instance;
		}

	   
	}
}
