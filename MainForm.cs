using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopAndVeterinaryManagementSystem
{
    public partial class MainForm : Form
    {
        
        public MainForm(string username)
        {
            InitializeComponent();
            this.label1.Text = username;
            DateTime currentDateTime = DateTime.Now;
            LblDatetime.Text = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void Loadform(object Form)     //create for pannel to call new forms
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }


        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            Loadform(Form: new DashBoard());
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            Loadform(Form: new BillForm());

        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            Loadform(Form: new ProductForm());

        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            Loadform(Form: new SupplierForm());

        }

        private void BtnEmp_Click(object sender, EventArgs e)
        {
            Loadform(Form: new EmployeeForm());

        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            Loadform(Form: new DoctorForm());

        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Loadform(Form: new Reports());


        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Loadform(Form: new CustomerForm());

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
