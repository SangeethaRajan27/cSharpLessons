using Humanizer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FirstMVCApp.Models
{
    public class EmpDbRespository
    {
        public static List<Emp> GetEmpList()
        {
            List<Emp> emplist = new List<Emp>();
            using(SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                //CreateCommand-query
                //execute- rows and columns
                SqlCommand selectempcmd = cn.CreateCommand();
                //It creates a SqlCommand named selectempcmd to execute a "SQL query" against the database. 
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read()) //one row at a time
                {
                    Emp emp = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3),
                    };
                    emplist.Add(emp);
                }
            }
                //using ---connection will be closed so we use using
                //create i/object streams ,connection,threaads inside using block
            return emplist;
        }
        public static Emp GetEmpById(int id)
        {
            Emp empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmps = "Select * from emptbl where eno=@id";
                selectempcmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;//"@ID" IS PARAMETER
                selectempcmd.CommandText = selectEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();//it will be null if the requested id is not found
                while (empdr.Read())
                {
                    empFound = new Emp
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)
                    };
                }
            }
            return empFound;
        }
        public static int AddNewEmp(Emp newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                //@id name should not be same as in emp.cs but @id and add(@id should be same
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.City;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.Salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();//not exceute a select statement
                //no of rows inserted-int value
            }
            return query_result;
        }
        public static int UpdateEmp(Emp modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.Id;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.Name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.City;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.Salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteEmp(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
