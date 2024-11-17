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
    public partial class ProductForm : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void AutoIdGeneration()
        {
            int Num = 0;
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string Sql = "SELECT Max(ID+1) FROM ProductTB";
            cmd = new SqlCommand(Sql);
            cmd.Connection = con;
            if (Convert.IsDBNull(cmd.ExecuteScalar()))
            {
                Num = 1;
                lblId.Text = Convert.ToString(Num);
                lblId.Text = Convert.ToString("ITM-" + Num);
            }
            else
            {
                Num = System.Convert.ToInt32((cmd.ExecuteScalar()));
                lblId.Text = Convert.ToString(Num);
                lblId.Text = Convert.ToString("ITM-" + Num);
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void rest()
        {
            TxtProductName.Text = "";
            CmbCategory.Text = "";
            TxtPrice.Text = "";
            Autocomplete();
        }

        private void Autocomplete()
        {
            try
            {
                CmbCategory.Items.Clear();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Category) from CategoryTable order by Category";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CmbCategory.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductFomr_Load(object sender, EventArgs e)
        {
            AutoIdGeneration();
            dataGridView1.DataSource = GetData();
            BtnAdd.Visible = true;
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            rest();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtProductName.Text == "")
            {
                MessageBox.Show("Please enter item name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtProductName.Focus();
                return;
            }
            if (CmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbCategory.Focus();
                return;
            }
            if (TxtPrice.Text == "")
            {
                MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrice.Focus();
                return;
            }
            try
            {
                string query = "INSERT INTO ProductTB(ProductId, ProductName, Category, Quantity, Price) VALUES (@ProductId, @ProductName, @Category, @Quantity, @Price)";

                using (SqlConnection con = new SqlConnection(cs.DBConn))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", lblId.Text);
                        cmd.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
                        cmd.Parameters.AddWithValue("@Category", CmbCategory.Text);
                        cmd.Parameters.AddWithValue("@Quantity", CmbQty.Text);
                        cmd.Parameters.AddWithValue("@Price", TxtPrice.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully saved", "Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    rest();
                }
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

        public DataView GetData()
        {
            var SelectQry = "select * from ProductTB ORDER BY Id asc";

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtProductName.Text == "")
            {
                MessageBox.Show("Please enter item name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtProductName.Focus();
                return;
            }
            if (CmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbCategory.Focus();
                return;
            }
            if (TxtPrice.Text == "")
            {
                MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrice.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update ProductTB set ProductName='" + TxtProductName.Text + "',Category='" + CmbCategory.Text + "',Quantity='" + CmbQty.Text + "',Price='" + TxtPrice.Text + "' Where ProductId='" + lblId.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();
                dataGridView1.DataSource = GetData();
                BtnAdd.Visible = true;
                BtnUpdate.Visible = false;
                BtnDelete.Visible = false;
                rest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_records()
        {
            try
            {
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cq = "delete from ProductTB where ProductID='" + lblId.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    BtnAdd.Visible = true;
                    BtnUpdate.Visible = false;
                    BtnDelete.Visible = false;
                    rest();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    BtnAdd.Visible = true;
                    BtnUpdate.Visible = false;
                    BtnDelete.Visible = false;
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

        private void Btntosearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string supnaME = TxtSupIdToSearch.Text; // TxtShopIdToSearch is a TextBox where the user enters the shopId to search for

                string searchQuery = "SELECT * FROM ProductTB WHERE ProductName=@SupName";
                cmd = new SqlCommand(searchQuery, con);
                cmd.Parameters.AddWithValue("@SupName", supnaME);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    // Populate your UI elements with the retrieved data
                    lblId.Text = rdr["ProductID"].ToString();
                    TxtProductName.Text = rdr["ProductName"].ToString();
                    TxtPrice.Text = rdr["Price"].ToString();
                    CmbCategory.Text = rdr["Category"].ToString();
                    CmbQty.Text = rdr["Quantity"].ToString();

                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (TxtProductName.Text == "")
            {
                MessageBox.Show("Please enter item name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtProductName.Focus();
                return;
            }
            if (CmbCategory.Text == "")
            {
                MessageBox.Show("Please select category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbCategory.Focus();
                return;
            }
            if (TxtPrice.Text == "")
            {
                MessageBox.Show("Please enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrice.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "SELECT * FROM ProductTB WHERE ProductName = @ProductName AND Category = @Category AND Price = @Price";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", TxtProductName.Text);
                    cmd.Parameters.AddWithValue("@Category", CmbCategory.Text);
                    cmd.Parameters.AddWithValue("@Price", TxtPrice.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Data found, display it or perform further actions as needed
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Search Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // No matching data found
                        MessageBox.Show("No matching records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                lblId.Text = dr.Cells[1].Value.ToString();
                TxtProductName.Text = dr.Cells[2].Value.ToString();
                CmbCategory.Text = dr.Cells[3].Value.ToString();
                TxtPrice.Text = dr.Cells[4].Value.ToString();
                BtnUpdate.Visible = true;
                BtnDelete.Visible = true;
                BtnAdd.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }
    }
}
