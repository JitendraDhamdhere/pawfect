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
    public partial class ForgetPassword : Form
    {

        private SqlDataReader rdr = null;
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private ConnectionString cs = new ConnectionString();
        private string generatedOtp;
        private bool isOtpGenerated = false;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOtpGenerated && ValidateInputFields())
                {


                    if (ValidateOtp())
                    {
                        UpdatePassword();
                    }



                    else
                    {
                        MessageBox.Show("Mail Not Found In Our Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = "";
                        txtEmail.Focus();
                    }
                }
                else if (!isOtpGenerated)
                {
                    MessageBox.Show("Please generate the OTP first by clicking on 'Send OTP'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void BtnSendOtp_Click(object sender, EventArgs e)
        {

            if (ValidateEmail())
            {
                isOtpGenerated = true;
                //  MessageBox.Show("OTP sent successfully. Please check your email.");
            }
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("All Fields Are Mandatory");
                return false;
            }

            if (txtEmail.Text.Contains(" "))
            {
                MessageBox.Show("Email Cannot Contain Space");
                return false;
            }

            return true;
        }

        // Method to validate the email and send OTP
        private bool ValidateEmail()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string query = "SELECT Mail FROM UserTable WHERE Mail=@find AND UType='A'";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@find", txtEmail.Text);
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    // Generate and send OTP
                    generatedOtp = GenerateOTP();
                    MessageBox.Show("Your OTP is: " + generatedOtp); // For testing, replace with actual email sending in production
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }

            return false;
        }

        // Method to validate the OTP entered by the user
        private bool ValidateOtp()
        {
            return textBox1.Text == generatedOtp;
        }

        // Method to update the password in the database
        private void UpdatePassword()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string query = "UPDATE UserTable SET Password=@Password WHERE Mail=@Mail";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Mail", txtEmail.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password Updated Successfully", "Forget Password Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                isOtpGenerated = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        // Method to generate a random OTP
        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        // Method to reset the input fields
        private void Reset()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            textBox1.Text = "";
        }
    }
}
