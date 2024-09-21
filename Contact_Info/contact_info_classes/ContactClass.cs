using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Info.contact_info_classes
{
    internal class ContactClass
    {

        //setter and getter

        public int id { get; set; }

        public string fName { get; set; }
        public string lName { get; set; }
        public string contact { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public string gender { get; set; }


        //  conecting database
        static string myConnStr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        //inserting  data into database

        public bool Insert(ContactClass contactClass)
        {
            //creatring a default return type and setting it's value to false first

            bool isSuccess = false;

            //connect the database
            SqlConnection conn = new SqlConnection(myConnStr);
            try
            {
                string sql = "INSERT INTO indo_table (FIRST_NAME, LAST_NAME, CONTACT, ADDRESS, EMAIL, GENDER) VALUES (@fName, @lName, @contact, @address, @email, @gender)";
                //create sql command using sql abd conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create a parameters to add data
                cmd.Parameters.AddWithValue("@fName", contactClass.fName);
                cmd.Parameters.AddWithValue("@lName", contactClass.lName);
                cmd.Parameters.AddWithValue("@contact", contactClass.contact);
                cmd.Parameters.AddWithValue("@address", contactClass.address);
                cmd.Parameters.AddWithValue("@email", contactClass.email);
                cmd.Parameters.AddWithValue("@gender", contactClass.gender);

                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the squery runs successfully then row > 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Select Data from db
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnStr);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM indo_table";
                //create cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, conn);
                //SQL Data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection 
                conn.Open();
                //create a adapter and fill with dt
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        //update data of database

        public bool update(ContactClass contactClass)
        {

            //return type
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnStr);
            try
            {
                //sql to update
                string sql = "UPDATE indo_table SET FIRST_NAME = @fName, LAST_NAME = @lName, CONTACT = @contact, ADDRESS = @address, EMAIL = @email, GENDER = @gender WHERE ID = @id";
                //create sql command using sql abd conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create a parameters to add data

                cmd.Parameters.AddWithValue("@id", contactClass.id);
                cmd.Parameters.AddWithValue("@fName", contactClass.fName);
                cmd.Parameters.AddWithValue("@lName", contactClass.lName);
                cmd.Parameters.AddWithValue("@contact", contactClass.contact);
                cmd.Parameters.AddWithValue("@address", contactClass.address);
                cmd.Parameters.AddWithValue("@email", contactClass.email);
                cmd.Parameters.AddWithValue("@gender", contactClass.gender);

                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the squery runs successfully then row > 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                conn.Close();
            }

            return isSuccess;


        }


        //delete data from database
        public bool Delete(ContactClass contactClass)
        {

            //return type
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnStr);
            try
            {
                //sql to delete
                string sql = "Delete FROM indo_table WHERE ID = @id";
                //create sql command using sql abd conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create a parameters to add data
                cmd.Parameters.AddWithValue("@id", contactClass.id);


                //open connection
                conn.Open();
                //execute query
                int rows = cmd.ExecuteNonQuery();

                //if the squery runs successfully then row > 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                conn.Close();
            }

            return isSuccess;


        }


        public DataTable search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myConnStr);
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM indo_table WHERE FIRST_NAME LIKE  '%" + keyword + "%' OR LAST_NAME LIKE  '%" + keyword + "%' OR Contact LIKE  '%" + keyword + "%' OR ADDRESS LIKE  '%" + keyword + "%' OR EMAIL LIKE  '%" + keyword + "%' ", conn);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

    }
}
