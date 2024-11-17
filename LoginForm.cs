using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopAndVeterinaryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //SqlDataAdapter rdr = null;
        DataTable dtable = new DataTable();
        //  SqlConnection con = null;
        //  SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (TxtUserId.Text == "")
            {
                MessageBox.Show("Please enter User id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserId.Focus();
                return;
            }
            if (TxtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConn);
                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand(
    "SELECT Name, Mail, Password FROM UserTable WHERE Mail = @Mail AND Password = @Password AND UType = 'A'",
                    myConnection
                );
                SqlParameter uName = new SqlParameter("@Mail", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                uName.Value = TxtUserId.Text;
                uPassword.Value = TxtPassword.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    MessageBox.Show("Login Successful !");
                    this.Hide();
                    MainForm frm = new MainForm(TxtUserId.Text);
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Clear();
                    TxtUserId.Clear();
                    TxtUserId.Focus();
                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnForgetPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
