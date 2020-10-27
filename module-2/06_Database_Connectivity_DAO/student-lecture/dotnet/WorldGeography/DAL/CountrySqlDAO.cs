using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }        

        public IList<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public IList<Country> GetCountries(string continent)
        {
            List<Country> List = new List<Country();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM country WHERE continent @continent", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        Country c = convertReaderToCountry(reader)
                            list.Add(c)
                    }
                }
            }
        }
    }
}
