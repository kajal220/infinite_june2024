using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CC2
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
          {
              InsertEmployeeDetails();
              SelectEmployeeData();
               Console.Read();
            }


     private static SqlConnection getConnection()
         {
              con = new SqlConnection("data source = ICS-LT-GSPS273\\SQLEXPRESS; initial catalog = Employeemanagement; integrated security = true;");
              con.Open();
              return con;
          }

            public static void InsertEmployeeDetails()
            {
                con = getConnection();

           
                string empName;
                decimal empSal;
                char empType;

               
                Console.WriteLine("Enter Employee Name:");
                empName = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                empSal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Employee Type (F for Fulltime, P for Parttime):");
                empType = Convert.ToChar(Console.ReadLine().ToUpper());

           
                cmd = new SqlCommand("Empdetails", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                
                cmd.Parameters.AddWithValue("@EmpName", empName);
                cmd.Parameters.AddWithValue("@Empsal", empSal);
                cmd.Parameters.AddWithValue("@Emptype", empType);

                
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Employee insertion successful.");
                }
                else
                {
                    Console.WriteLine("Employee insertion failed.");
                }
            }


        public static void SelectEmployeeData()
        {
            con = getConnection();

            cmd = new SqlCommand("SELECT * FROM Employee_Details", con);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr["Empno"]} | {dr["EmpName"]} | {dr["Empsal"]} | {dr["Emptype"]}");
            }

            dr.Close();
            Console.Read();
        }
        }
    }
