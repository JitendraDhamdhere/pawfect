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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter Customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
            if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please enter Mail id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Please enter Contact No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Contact from CustomerTable where Contact='" + txtContactNo.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Mobile number Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContactNo.Text = "";
                    txtContactNo.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into CustomerTable(CustomerId,CustomerName,EmailAddress,Contact,Address) VALUES ('" + txtCustomerId.Text + "','" + txtCustomerName.Text + "','" + txtEmailAddress.Text + "','" + txtContactNo.Text + "','" + txtAddress.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();
                dataGridView1.DataSource = GetData();
                rest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBConn);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            rest();
            AutoIdGeneration();
            dataGridView1.DataSource = GetData();
            btnSave.Visible = true;
        
        }

        private void AutoIdGeneration()
        {
            int Num = 0;
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string sql = "SELECT Max(ID+1) FROM CustomerTable";
            cmd = new SqlCommand(sql);
            cmd.Connection = con;
            if (Convert.IsDBNull(cmd.ExecuteScalar()))
            {
                Num = 1;
                lblId.Text = Convert.ToString(Num);
                txtCustomerId.Text = Convert.ToString("CUST" + Num);
            }
            else
            {
                Num = System.Convert.ToInt32((cmd.ExecuteScalar()));
                lblId.Text = Convert.ToString(Num);
                txtCustomerId.Text = Convert.ToString("CUST" + Num);
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void rest()
        {
            txtCustomerName.Text = "";
            txtSearch.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtEmailAddress.Text = "";
          
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            AutoIdGeneration();
            dataGridView1.DataSource = GetData();
            btnSave.Visible = true;
          
            rest();
        }
        public DataView GetData()
        {
            var SelectQry = "select * from CustomerTable ORDER BY Id asc";

            DataSet SampleSource = new DataSet();
            DataView TableView;
            try
            {
                SqlCommand SampleCommand = new SqlCommand();
                var SampleDataAdapter = new SqlDataAdapter();
                SampleCommand.CommandText = SelectQry;
                SampleCommand.Connection = Connection;
                SampleDataAdapter.SelectCommand = SampleCommand;
                SampleDataAdapter.Fill(SampleSource);
                TableView = SampleSource.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TableView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)  // Check if any row is selected
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    txtCustomerId.Text = dr.Cells[1].Value.ToString();
                    txtCustomerName.Text = dr.Cells[2].Value.ToString();
                    txtEmailAddress.Text = dr.Cells[3].Value.ToString();
                    txtContactNo.Text = dr.Cells[4].Value.ToString();
                    txtAddress.Text = dr.Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter Customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
            if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please enter Mail id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Please enter Contact No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update CustomerTable set CustomerName='" + txtCustomerName.Text + "',EmailAddress='" + txtEmailAddress.Text + "',Contact='" + txtContactNo.Text + "',Address='" + txtAddress.Text + "' Where CustomerId='" + txtCustomerId.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();
                dataGridView1.DataSource = GetData();
               
                rest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from CustomerTable where CustomerId='" + txtCustomerId.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                  
                    rest();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    btnSave.Visible = true;
                  
                    rest();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("select * from CustomerTable where CustomerName like '%" + txtSearch.Text + "%' or Contact like '%" + txtSearch.Text + "%'  order by Id", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "CustomerTable");
                dataGridView1.DataSource = myDataSet.Tables["CustomerTable"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

     
    }

}
