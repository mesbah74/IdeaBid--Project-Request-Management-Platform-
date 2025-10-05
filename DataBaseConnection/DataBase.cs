using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IdeaBid__Project_Request___Management_Platform.DataBaseConnection
{
    public static class DataBase
    {
        private const string ConnectionString = @"Data Source=TAMIM\SQLEXPRESS;Initial Catalog=IdeaBid;Integrated Security=True;TrustServerCertificate=True";

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("That username or email is already registered.", "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            catch (SqlException ex) when (ex.Number == 8152)
            {
                MessageBox.Show("One of your inputs is too long. Please shorten it.", "Data Too Long", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static string AuthenticateRole(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            string query = @"
                SELECT TOP 1 Role FROM (
                    SELECT 'Admin' AS Role FROM AdminInfo
                    WHERE AdminUsername = @u
                    AND AdminPassword COLLATE SQL_Latin1_General_CP1_CS_AS = @p
                    UNION ALL
                    SELECT 'Dev' FROM DevInfo
                    WHERE DevUsername = @u
                    AND DevPassword COLLATE SQL_Latin1_General_CP1_CS_AS = @p
                    UNION ALL
                    SELECT 'User' FROM UserInfo
                    WHERE UserName = @u
                    AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @p
                ) UserRoles;";

            try
            {
                var parameters = CreateParameters(
                    ("@u", username),
                    ("@p", password)
                );

                object result = ExecuteScalar(query, parameters);
                return result?.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static (bool usernameExists, bool emailExists) CheckUsernameOrEmailExists(string username, string email)
        {
            string userQuery = @"
                SELECT TOP 1 1 FROM (
                    SELECT AdminUsername AS val FROM AdminInfo
                    UNION ALL
                    SELECT DevUsername FROM DevInfo
                    UNION ALL
                    SELECT UserName FROM UserInfo
                ) x
                WHERE val = @u;";

            string emailQuery = @"
                SELECT TOP 1 1 FROM (
                    SELECT AdminEmail AS val FROM AdminInfo
                    UNION ALL
                    SELECT DevEmail FROM DevInfo
                    UNION ALL
                    SELECT Email FROM UserInfo
                ) x
                WHERE val = @e;";

            try
            {
                var userParam = CreateParameters(("@u", username ?? ""));
                var emailParam = CreateParameters(("@e", email ?? ""));

                bool uExists = ExecuteScalar(userQuery, userParam) != null;
                bool eExists = ExecuteScalar(emailQuery, emailParam) != null;

                return (uExists, eExists);
            }
            catch (Exception)
            {
                return (false, false);
            }
        }

        public static SqlParameter CreateParameter(string name, object value)
        {
            if (!name.StartsWith("@")) name = "@" + name;
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        public static SqlParameter[] CreateParameters(params (string name, object value)[] parameters)
        {
            SqlParameter[] sqlParams = new SqlParameter[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                sqlParams[i] = CreateParameter(parameters[i].name, parameters[i].value);
            }
            return sqlParams;
        }



        public static DataTable GetDataTable(string sql, SqlParameter[] parameters = null)
        {
            var dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }



    public static class ValidationHelper
    {
        public static (string error, string field) ValidateUserInput(
                 string username,
                 string fullName,
                 string email,
                 string password,
                 string userType)
        {

            if (string.IsNullOrWhiteSpace(username))
                return ("Please enter a username.", "username");

            if (username.Length < 4 || username.Length > 50)
                return ("Username should be 4 to 50 characters long.", "username");

            if (string.IsNullOrWhiteSpace(fullName))
                return ("Please enter full name.", "fullname");

            if (string.IsNullOrWhiteSpace(email))
                return ("Please enter an email address.", "email");

            if (!email.Contains("@") || !email.Contains("."))
                return ("Please enter a valid email address (e.g., name@example.com).", "email");

            if (string.IsNullOrWhiteSpace(userType))
                return ("Please select a user type.", "usertype");

            if (string.IsNullOrWhiteSpace(password))
                return ("Please enter a password.", "password");

            if (password.Length < 4 || password.Length > 20)
                return ("Password should be 4 to 20 characters long.", "password");

            //var (userExists, emailExists) = DataBase.CheckUsernameOrEmailExists(username, email);
            //if (userExists)
            //    return ("Username already exists. Please choose another.", "username");
            //if (emailExists)
            //    return ("Email already exists. Please use another.", "email");



            return (null, null);
        }

    }

}
