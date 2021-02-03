using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment02feb2021Con
{

    class Customer
    {
        public int Cid { get; set; }
        public string CName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
    }
    class Program
    {

		static void CustomerDetails()
		{
			SqlConnection con = null;
			SqlCommand cmd = null;
			SqlDataReader dr = null;
			List<Customer> detailList;
			try
			{
				detailList = new List<Customer>();
				using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
				{
					using (cmd = new SqlCommand("SELECT * FROM tblCustomer02feb", con))
					{
						con.Open();
						using (dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
						{
							while (dr.Read())
							{
								detailList.Add(new Customer
								{
									Cid = dr.GetFieldValue<int>(dr.GetOrdinal("Cid")),
									CName = dr.GetFieldValue<string>(dr.GetOrdinal("CName")),
									DOB = dr.GetFieldValue<DateTime>(dr.GetOrdinal("DOB")),
									City = dr.GetFieldValue<string>(dr.GetOrdinal("City"))
								});
							}
						}
					}
				}
				Console.WriteLine("Customer Details");
                Console.WriteLine(".................................................");

				var res = detailList.GetEnumerator();
				while (res.MoveNext())
				{
					Console.WriteLine("Cid as     : " + res.Current.Cid);
					Console.WriteLine("CName as   : " + res.Current.CName);
					Console.WriteLine("DOB as     : " + res.Current.DOB);
					Console.WriteLine("City as    : " + res.Current.City);
					Console.WriteLine("----------------------------------------------------");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		static void Main(string[] args)
        {
			CustomerDetails();
		}
    }
}
