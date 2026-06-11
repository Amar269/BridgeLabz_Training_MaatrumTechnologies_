using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace reviewquestion
{
    public class progrma
    {
        static void Main()
        {
            string cs =
          "Server=LAPTOP-FTFELM8T\\SQLEXPRESS;" +
           "Database=Student_db;" +
          "Trusted_Connection=True;" +
          "TrustServerCertificate=True;";

            using SqlConnection con = new SqlConnection(cs);
          {




                /*
                 // udpdated the data in students and employees table
                 
                SqlCommand cmd = new SqlCommand("update  Student set  s_name = 'Amaruuu' where s_id = 1", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }

                Console.WriteLine("data updated in employees table");

                
                SqlCommand cmd = new SqlCommand("update  employees set  emp_name = 'Amarnath' where emp_id = 101", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }

                Console.WriteLine("data updated in employees table");

                */







                /*
                // add data into data  students
                SqlCommand cmd = new SqlCommand("insert into employees values('Amar' , 'amar@srmsit.edu.in'),('kolla' , 'kolla@srmsit.edu.in') , ('srm' , 'srm@srmsit.edu.in') , ('four' , 'four@srmsit.edu.in')", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+ " " + reader[1] + " " + reader[2]);  
                }
                
                 Console.WriteLine("data inserted");


                // add data into data  students 
                SqlCommand cmd = new SqlCommand("insert into  Student values('RRR' , 'PANINDIA@srmsit.edu.in'),('CSK' , 'cskadmin@srmsit.edu.in')", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+ " " + reader[1] + " " + reader[2]); 
               
                }



                Console.WriteLine("data inserted");
                */







                /*
                // sp


                // student tbale codes 
                
                
                    SqlCommand cmd = new SqlCommand("s_viewstudent", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pstd_id", 1);
                         con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("Student ID : " + dr["s_id"]);
                        Console.WriteLine("Name       : " + dr["s_name"]);
                        Console.WriteLine("Email      : " + dr["s_email"]);
                       
                    }

                    dr.Close();




                SqlCommand cmd = new SqlCommand("s_deletestudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@del_id", 5);
                con.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Student Deleted Successfully");
                else
                    Console.WriteLine("Student Not Found");






                // employees table codes


                 SqlCommand cmd = new SqlCommand("emp_viewemployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@emps_id", 101);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Employee ID : " + dr["emp_id"]);
                    Console.WriteLine("Name       : " + dr["emp_name"]);
                    Console.WriteLine("Email      : " + dr["emp_email"]);

                }

                dr.Close();



                SqlCommand cmd = new SqlCommand("emp_deleteemployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@emp_del_id", 103);
                con.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Employee Deleted Successfully");
                else
                    Console.WriteLine("Employee Not Found");

                */















          }

        }
    }
}


