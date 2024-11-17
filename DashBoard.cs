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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        SqlConnection con = null;
        SqlCommand cmd = null;
        // DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
        public void TotalUnits()
        {
            try
            {
                using (con = new SqlConnection(cs.DBConn))
                {
                    con.Open();
                    using (cmd = new SqlCommand("SELECT COUNT(Id) FROM BillDetailsTable", con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            Noofsales.Text = result.ToString();
                        }
                        else
                        {
                            Noofsales.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            TotalUnits();
            TotalRevenue();
            TotalProfit();
            dataGridView1.DataSource = GetData();
            PopulateCharts();
            PopulateUnderstockGrid();
        }

        private void TotalProfit()
        {
            try
            {
                using (con = new SqlConnection(cs.DBConn))
                {
                    con.Open();
                    using (cmd = new SqlCommand("SELECT SUM(Total) FROM BillDetailsTable", con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label3.Text = result.ToString();
                        }
                        else
                        {
                            label3.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalRevenue()
        {
            try
            {
                using (con = new SqlConnection(cs.DBConn))
                {
                    con.Open();
                    using (cmd = new SqlCommand("SELECT SUM(Total) FROM BillDetailsTable", con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            TotalRevenu.Text = result.ToString();
                        }
                        else
                        {
                            TotalRevenu.Text = "0";
                        }
                    }
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

                TableView = new DataView(SampleSource.Tables[0]);
                TableView.RowFilter = "Quantity < 10";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return TableView;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateCharts()
        {
            try
            {
                using (con = new SqlConnection(cs.DBConn))
                {
                    con.Open();

                    // Query to get aggregated data for charts
                    string query = @"
                SELECT 
                    SUM(GrandTotal) AS Revenue, 
                    SUM(Total) - SUM(DiscountPrice) AS Profit, 
                    COUNT(Id) AS Orders 
                FROM BillInfoTable";

                    using (cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                double revenue = reader["Revenue"] != DBNull.Value ? Convert.ToDouble(reader["Revenue"]) : 0;
                                double profit = reader["Profit"] != DBNull.Value ? Convert.ToDouble(reader["Profit"]) : 0;
                                double orders = reader["Orders"] != DBNull.Value ? Convert.ToDouble(reader["Orders"]) : 0;

                                // Clear previous data
                                chart1.Series["Data"].Points.Clear();
                                chart2.Series["Data"].Points.Clear();

                                // Add data to charts
                                chart1.Series["Data"].Points.AddXY("Revenue", revenue);
                                chart1.Series["Data"].Points.AddXY("Profit", profit);
                                chart1.Series["Data"].Points.AddXY("Orders", orders);

                                chart2.Series["Data"].Points.AddXY("Revenue", revenue);
                                chart2.Series["Data"].Points.AddXY("Profit", profit);
                                chart2.Series["Data"].Points.AddXY("Orders", orders);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating charts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }

        }

        private void PopulateUnderstockGrid()
        {
            try
            {
                using (con = new SqlConnection(cs.DBConn))
                {
                    con.Open();
                    string query = "SELECT ID, ProductID, ProductName, Category, Quantity, Price FROM ProductTB WHERE Quantity < 10";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading understock products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
