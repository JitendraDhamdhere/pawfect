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
    public partial class SupplierForm : Form
    {

        SqlDataReader rdr = null;
        readonly DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void AutoIdGeneration()
        {
            try
            {
                int Num = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string Sql = "SELECT Max(ID+1) FROM SupplierTable";
                cmd = new SqlCommand(Sql);
                cmd.Connection = con;
                if (Convert.IsDBNull(cmd.ExecuteScalar()))
                {
                    Num = 1;
                    lblId.Text = Convert.ToString(Num);
                    lblId.Text = Convert.ToString("SUP-" + Num);
                }
                else
                {
                    Num = System.Convert.ToInt32((cmd.ExecuteScalar()));
                    lblId.Text = Convert.ToString(Num);
                    lblId.Text = Convert.ToString("SUP-" + Num);
                }
                cmd.Dispose();
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (TxtSupName.Text == "")
            {
                MessageBox.Show("Please enter supplier name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSupName.Focus();
                return;
            }
            if (TxtContactNo.Text == "")
            {
                MessageBox.Show("Please enter contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtContactNo.Focus();
                return;
            }
            if (TxtAddress.Text == "")
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAddress.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into SupplierTable(SupID,SupName,ContactNo,Address,Category) VALUES ('" + lblId.Text + "','" + TxtSupName.Text + "','" + TxtContactNo.Text + "','" + TxtAddress.Text + "','" + CmbCategoery.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Supplier Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (TxtSupName.Text == "")
            {
                MessageBox.Show("Please enter supplier name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSupName.Focus();
                return;
            }
            if (TxtContactNo.Text == "")
            {
                MessageBox.Show("Please enter contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtContactNo.Focus();
                return;
            }
            if (TxtAddress.Text == "")
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAddress.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update SupplierTable set SupName='" + TxtSupName.Text + "', ContactNo='" + TxtContactNo.Text + "', Address='" + TxtAddress.Text + "',Category='" + CmbCategoery.Text + "' Where SupID='" + lblId.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Supplier Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string supnaME = TxtSupIdToSearch.Text; // TxtShopIdToSearch is a TextBox where the user enters the shopId to search for

                string searchQuery = "SELECT * FROM SupplierTable WHERE SupName=@SupName";
                cmd = new SqlCommand(searchQuery, con);
                cmd.Parameters.AddWithValue("@SupName", supnaME);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    // Populate your UI elements with the retrieved data
                    lblId.Text = rdr["SupID"].ToString();
                    TxtSupName.Text = rdr["SupName"].ToString();
                    CmbCategoery.Text = rdr["Category"].ToString();
                    TxtContactNo.Text = rdr["ContactNo"].ToString();
                    TxtAddress.Text = rdr["Address"].ToString();

                }
                else
                {
                    MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clear the fields or handle as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private void GetDataFromDatabase()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "SELECT TOP 10" +
                    " * FROM SupplierTable ORDER BY SupID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "SupplierTable");
                con.Close();

                // Bind data to ListView
                listView1.Items.Clear();
                foreach (DataRow row in ds.Tables["SupplierTable"].Rows)
                {
                    ListViewItem item = new ListViewItem(row["SupID"].ToString());
                    item.SubItems.Add(row["SupName"].ToString());
                    item.SubItems.Add(row["Category"].ToString());
                    item.SubItems.Add(row["ContactNo"].ToString());
                    item.SubItems.Add(row["Address"].ToString());

                    listView1.Items.Add(item);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        void Reset()
        {
            TxtSupName.Text = "";
            TxtAddress.Text = "";
            CmbCategoery.Text = "";
            TxtContactNo.Text = "";

            AutoIdGeneration();
            GetDataFromDatabase();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
