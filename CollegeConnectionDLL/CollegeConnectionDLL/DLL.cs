using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeConnectionDLL
{
    public class DLL
    {
        //Connection to the database
        private static SqlConnection _cntITSE1392 = new SqlConnection(@"Server='';Database=''; User Id=''; password=''");
        private static StringBuilder _errorMessages = new StringBuilder();

        //Sql commands
        private static SqlCommand _sqlCommand;
        private static SqlDataReader _sqlDataReader;

        //Objects for Account Table
        private static SqlDataAdapter _daAccountLogin = new SqlDataAdapter();
        private static DataTable _dtAccountLogin = new DataTable();

        private static SqlDataAdapter _daChat = new SqlDataAdapter();
        private static DataTable _dtChat = new DataTable();

        public static DataTable Account
        {
            get { return _dtAccountLogin; }
        }

        public static DataTable Chat
        {
            get { return _dtChat; }
        }

        private static string User = "";

        public static void OpenDatabase()
        {
            //method to open database
            try
            {
                //open the connection to Account database
                _cntITSE1392.Open();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - OpenDatabase)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Code that will take the user's login and password
        public static bool UserLogin(string ID, string Password)
        {
            try
            {
                User = ID;
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select ID from alarafa201392.AccountInfo where ID = '" + ID + "'", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
                if (_sqlDataReader.Read())
                {
                    if (ID == _sqlDataReader["ID"].ToString())
                    {
                        _sqlDataReader.Close();
                        _sqlCommand = new SqlCommand("Select ID, Password, Admin from alarafa201392.AccountInfo where ID = '" + ID + "' and Password = '" + Password + "'", _cntITSE1392);
                        _sqlDataReader = _sqlCommand.ExecuteReader();
                    }
                    if (_sqlDataReader.Read())
                    {
                        if (ID == _sqlDataReader["ID"].ToString() && Password == _sqlDataReader["Password"].ToString())
                        {
                            MessageBox.Show("Welcome User");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.");
                        _sqlDataReader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No matching username has been found, try again");
                }
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - UserLogin)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public static bool AdminLogin(string ID, string Password)
        {
            try
            {
                User = ID;
                string Admin = "True";
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select ID from alarafa201392.AccountInfo where ID = '" + ID + "'", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
                if (_sqlDataReader.Read())
                {
                    if (ID == _sqlDataReader["ID"].ToString())
                    {
                        _sqlDataReader.Close();
                        _sqlCommand = new SqlCommand("Select ID, Password, Admin from alarafa201392.AccountInfo where ID = '" + ID + "' and Password = '" + Password + "'", _cntITSE1392);
                        _sqlDataReader = _sqlCommand.ExecuteReader();
                    }
                    if (_sqlDataReader.Read())
                    {
                        if (ID == _sqlDataReader["ID"].ToString() && Password == _sqlDataReader["Password"].ToString() && Admin == _sqlDataReader["Admin"].ToString())
                        {
                            MessageBox.Show("Welcome Admin");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.");
                        _sqlDataReader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No matching username has been found, try again");
                }
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - AdminLogin)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public static void AccountInfo(Label ID, Label FirstName, Label LastName, Label Age, Label State, Label City, Label Address, Label Zip, Label Graduated, Label Work, Label Salary, Label Education, Label Story, PictureBox Picture)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select * from alarafa201392.AccountInfo where ID = '" + User + "'", _cntITSE1392);
                _daAccountLogin = new SqlDataAdapter();
                _daAccountLogin.SelectCommand = _sqlCommand;
                _dtAccountLogin = new DataTable();
                _daAccountLogin.Fill(_dtAccountLogin);

                ID.DataBindings.Add("Text", _dtAccountLogin, "ID");
                FirstName.DataBindings.Add("Text", _dtAccountLogin, "FirstName");
                LastName.DataBindings.Add("Text", _dtAccountLogin, "LastName");
                Age.DataBindings.Add("Text", _dtAccountLogin, "Age");
                State.DataBindings.Add("Text", _dtAccountLogin, "State");
                City.DataBindings.Add("Text", _dtAccountLogin, "City");
                Address.DataBindings.Add("Text", _dtAccountLogin, "Address");
                Zip.DataBindings.Add("Text", _dtAccountLogin, "Zip");
                Graduated.DataBindings.Add("Text", _dtAccountLogin, "Graduated");
                Work.DataBindings.Add("Text", _dtAccountLogin, "Work");
                Salary.DataBindings.Add("Text", _dtAccountLogin, "Salary");
                Education.DataBindings.Add("Text", _dtAccountLogin, "HigherEducation");
                Story.DataBindings.Add("Text", _dtAccountLogin, "Story");
                Picture.DataBindings.Add("Image", _dtAccountLogin, "Picture", true);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - StudentInfo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void LoadAll(Label ID, Label FirstName, Label LastName, Label Age, Label State, Label City, Label Address, Label Zip, Label Graduated, Label Work, Label Salary, Label Education, Label Story, PictureBox Picture)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select * from alarafa201392.AccountInfo", _cntITSE1392);
                _daAccountLogin = new SqlDataAdapter();
                _daAccountLogin.SelectCommand = _sqlCommand;
                _dtAccountLogin = new DataTable();
                _daAccountLogin.Fill(_dtAccountLogin);

                ID.DataBindings.Add("Text", _dtAccountLogin, "ID");
                FirstName.DataBindings.Add("Text", _dtAccountLogin, "FirstName");
                LastName.DataBindings.Add("Text", _dtAccountLogin, "LastName");
                Age.DataBindings.Add("Text", _dtAccountLogin, "Age");
                State.DataBindings.Add("Text", _dtAccountLogin, "State");
                City.DataBindings.Add("Text", _dtAccountLogin, "City");
                Address.DataBindings.Add("Text", _dtAccountLogin, "Address");
                Zip.DataBindings.Add("Text", _dtAccountLogin, "Zip");
                Graduated.DataBindings.Add("Text", _dtAccountLogin, "Graduated");
                Work.DataBindings.Add("Text", _dtAccountLogin, "Work");
                Salary.DataBindings.Add("Text", _dtAccountLogin, "Salary");
                Education.DataBindings.Add("Text", _dtAccountLogin, "HigherEducation");
                Story.DataBindings.Add("Text", _dtAccountLogin, "Story");
                Picture.DataBindings.Add("Image", _dtAccountLogin, "Picture", true);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - StudentInfo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void EditInfo(string ID, string FirstName, string LastName, string Age, string State, string City, string Address, string Zip, string Work, string Salary, string HigherEducation, string Story)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Update alarafa201392.AccountInfo set FirstName = '" + FirstName + "', LastName = '" + LastName + "', Age = '" + Age + "', State = '" + State + "', City = '" + City + "', Address = '" + Address + "', Zip = '" + Zip + "', Work = '" + Work + "', Salary = '" + Salary + "', HigherEducation = '" + HigherEducation + "' where ID = '" + ID + "'", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - EditInfo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void EditPhoto(string ID, byte[] Picture)
        {
            _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
            _cntITSE1392.Open();
            _sqlCommand = new SqlCommand("Update alarafa201392.AccountInfo set Picture = @picture where ID = '" + ID + "'", _cntITSE1392);
            _sqlCommand.Parameters.AddWithValue("@picture", Picture);
            _sqlDataReader = _sqlCommand.ExecuteReader();
        }

        public static void AddAccount(string ID, string Password, string FirstName, string LastName, string Age, string State, string City, string Address, string Zip, string Graduated, string Admin, string Work, string Salary, string HigherEducation, string Story, byte[] Picture, string ShareStory)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Insert into alarafa201392.AccountInfo (ID, Password, FirstName, LastName, Age, State, City, Address, Zip, Graduated, Admin, Work, Salary, HigherEducation, Story, ShareStory, Picture) values ('" + ID + "','" + Password + "','" + FirstName + "','" + LastName + "','" + Age + "','" + State + "','" + City + "','" + Address + "','" + Zip + "','" + Graduated + "','" + Admin + "','" + Work + "','" + Salary + "','" + HigherEducation + "','" + Story + "','" + ShareStory + "', @picture)", _cntITSE1392);
                _sqlCommand.Parameters.AddWithValue("@picture", Picture);
                _sqlDataReader = _sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - AddAccount)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteAccount(string ID)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Delete from alarafa201392.AccountInfo where ID = '" + ID + "'", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - DeleteAccount)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadAccounts(TextBox ID, TextBox Password, TextBox FirstName, TextBox LastName, TextBox Age, TextBox State, TextBox City, TextBox Address, TextBox Zip, TextBox Graduated, TextBox Admin, TextBox Work, TextBox Salary, TextBox Education, TextBox Story, TextBox Share, PictureBox Picture)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select * from alarafa201392.AccountInfo", _cntITSE1392);
                _daAccountLogin = new SqlDataAdapter();
                _daAccountLogin.SelectCommand = _sqlCommand;
                _dtAccountLogin = new DataTable();
                _daAccountLogin.Fill(_dtAccountLogin);

                ID.DataBindings.Add("Text", _dtAccountLogin, "ID");
                Password.DataBindings.Add("Text", _dtAccountLogin, "Password");
                FirstName.DataBindings.Add("Text", _dtAccountLogin, "FirstName");
                LastName.DataBindings.Add("Text", _dtAccountLogin, "LastName");
                Age.DataBindings.Add("Text", _dtAccountLogin, "Age");
                State.DataBindings.Add("Text", _dtAccountLogin, "State");
                City.DataBindings.Add("Text", _dtAccountLogin, "City");
                Address.DataBindings.Add("Text", _dtAccountLogin, "Address");
                Zip.DataBindings.Add("Text", _dtAccountLogin, "Zip");
                Graduated.DataBindings.Add("Text", _dtAccountLogin, "Graduated");
                Admin.DataBindings.Add("Text", _dtAccountLogin, "Admin");
                Work.DataBindings.Add("Text", _dtAccountLogin, "Work");
                Salary.DataBindings.Add("Text", _dtAccountLogin, "Salary");
                Education.DataBindings.Add("Text", _dtAccountLogin, "HigherEducation");
                Share.DataBindings.Add("Text", _dtAccountLogin, "ShareStory");
                Story.DataBindings.Add("Text", _dtAccountLogin, "Story");
                Picture.DataBindings.Add("Image", _dtAccountLogin, "Picture", true);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - AdminInfo)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadMessages(DataGridView dgvChat)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Select * from alarafa201392.ChatLog", _cntITSE1392);
                _daChat = new SqlDataAdapter();
                _daChat.SelectCommand = _sqlCommand;
                _dtChat = new DataTable();
                _daChat.Fill(_dtChat);
                dgvChat.DataSource = _dtChat;
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - LoadMessage)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LogChanges(string ID, string FirstName, string LastName, string Age, string State, string City, string Address, string Zip, string Graduated, string Admin, string Work, string Salary, string HigherEducation, string Story, string ShareStory)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Insert into alarafa201392.ChangeLog (ID, FirstName, LastName, Age, State, City, Address, Zip, Graduated, Admin, Work, Salary, HigherEducation, Story, ShareStory) values ('" + ID + "','" + FirstName + "','" + LastName + "','" + Age + "','" + State + "','" + City + "','" + Address + "','" + Zip + "','" + Graduated + "','" + Admin + "','" + Work + "','" + Salary + "','" + HigherEducation + "','" + Story + "','" + ShareStory + "')", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - AddAccount)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LogMessage(string Message)
        {
            try
            {
                _cntITSE1392 = new SqlConnection(@"Server=cstnt.tstc.edu;Database=itse1392fa20; User Id=alarafa201392; password=1638146");
                _cntITSE1392.Open();
                _sqlCommand = new SqlCommand("Insert into alarafa201392.ChatLog (Sender, Message) values ('" + User + "','" + Message + "')", _cntITSE1392);
                _sqlDataReader = _sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps - LogMessage)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CloseDisposeDatabase()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntITSE1392.Close();
                //dispose of the sql objects
                _cntITSE1392.Dispose();
                _sqlCommand.Dispose();
                _daAccountLogin.Dispose();
                _dtAccountLogin.Dispose();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (ProgOps  - Close Database)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
