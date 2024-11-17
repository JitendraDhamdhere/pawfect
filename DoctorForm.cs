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
    public partial class DoctorForm : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "")
            {
                MessageBox.Show("Please enter Doctor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDoctorName.Focus();
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
            if (txtSalary.Text == "")
            {
                MessageBox.Show("Please enter salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalary.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Contact from DoctorTable where Contact='" + txtContactNo.Text + "'";

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
                string cb = "insert into DoctorTable(DoctorId,DoctorName,Email,Contact,Gender,Address,Salary,DateOfJoin) VALUES ('" + txtDoctorId.Text + "','" + txtDoctorName.Text + "','" + txtEmailAddress.Text + "','" + txtContactNo.Text + "','" + cmbGender.Text + "','" + txtAddress.Text + "','" + txtSalary.Text + "','" + DpDateOfJoin.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully saved", "Doctor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();
                dataGridView1.DataSource = GetData();
                rest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            rest();
            AutoIdGeneration();
            dataGridView1.DataSource = GetData();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void AutoIdGeneration()
        {
            int Num = 0;
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string sql = "SELECT Max(ID+1) FROM DoctorTable";
            cmd = new SqlCommand(sql);
            cmd.Connection = con;
            if (Convert.IsDBNull(cmd.ExecuteScalar()))
            {
                Num = 1;
                lblId.Text = Convert.ToString(Num);
                txtDoctorId.Text = Convert.ToString("Doc" + Num);
            }
            else
            {
                Num = System.Convert.ToInt32((cmd.ExecuteScalar()));
                lblId.Text = Convert.ToString(Num);
                txtDoctorId.Text = Convert.ToString("Doc" + Num);
            }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void rest()
        {
            txtDoctorName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtEmailAddress.Text = "";
            txtSalary.Text = "";
            cmbGender.Text = "";
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            AutoIdGeneration();
            dataGridView1.DataSource = GetData();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            rest();
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
            var SelectQry = "select * from DoctorTable ORDER BY Id asc";

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                txtDoctorId.Text = dr.Cells[1].Value.ToString();
                txtDoctorName.Text = dr.Cells[2].Value.ToString();
                txtEmailAddress.Text = dr.Cells[3].Value.ToString();
                txtContactNo.Text = dr.Cells[4].Value.ToString();
                cmbGender.Text = dr.Cells[5].Value.ToString();
                txtAddress.Text = dr.Cells[6].Value.ToString();
                txtSalary.Text = dr.Cells[7].Value.ToString();
                DpDateOfJoin.Text = dr.Cells[8].Value.ToString();
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "")
            {
                MessageBox.Show("Please enter Dcotor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDoctorName.Focus();
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
            if (txtSalary.Text == "")
            {
                MessageBox.Show("Please enter salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalary.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "Update DoctorTable set DoctorName='" + txtDoctorName.Text + "',Email='" + txtEmailAddress.Text + "',Contact='" + txtContactNo.Text + "',Gender='" + cmbGender.Text + "',Address='" + txtAddress.Text + "',Salary='" + txtSalary.Text + "',DateOfJoin='" + DpDateOfJoin.Text + "' Where DoctorId='" + txtDoctorId.Text + "'";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Doctor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoIdGeneration();
                dataGridView1.DataSource = GetData();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
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
                string cq = "delete from DoctorTable where DoctorId='" + txtDoctorId.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                    rest();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoIdGeneration();
                    dataGridView1.DataSource = GetData();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
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
                cmd = new SqlCommand("select * from DoctorTable where DoctorName like '%" + txtSearch.Text + "%' or Contact like '%" + txtSearch.Text + "%'  order by Id", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "DoctorTable");
                dataGridView1.DataSource = myDataSet.Tables["DoctorTable"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {
           
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

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
