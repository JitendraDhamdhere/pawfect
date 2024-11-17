
namespace PetShopAndVeterinaryManagementSystem
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSupIdToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.CmbCategoery = new System.Windows.Forms.ComboBox();
            this.LblCategoery = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.MangAddr = new System.Windows.Forms.Label();
            this.TxtContactNo = new System.Windows.Forms.TextBox();
            this.LblContNo = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSupName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SupplierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.PanelDetails.Controls.Add(this.BtnSearch);
            this.PanelDetails.Controls.Add(this.TxtSupIdToSearch);
            this.PanelDetails.Controls.Add(this.guna2Button3);
            this.PanelDetails.Controls.Add(this.guna2Button2);
            this.PanelDetails.Controls.Add(this.CmbCategoery);
            this.PanelDetails.Controls.Add(this.LblCategoery);
            this.PanelDetails.Controls.Add(this.TxtAddress);
            this.PanelDetails.Controls.Add(this.MangAddr);
            this.PanelDetails.Controls.Add(this.TxtContactNo);
            this.PanelDetails.Controls.Add(this.LblContNo);
            this.PanelDetails.Controls.Add(this.LblSupplier);
            this.PanelDetails.Controls.Add(this.lblId);
            this.PanelDetails.Controls.Add(this.label2);
            this.PanelDetails.Controls.Add(this.TxtSupName);
            this.PanelDetails.Location = new System.Drawing.Point(0, 49);
            this.PanelDetails.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(1078, 231);
            this.PanelDetails.TabIndex = 133;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.Color.SlateGray;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(569, 181);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(138, 42);
            this.BtnSearch.TabIndex = 162;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSupIdToSearch
            // 
            this.TxtSupIdToSearch.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TxtSupIdToSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtSupIdToSearch.Location = new System.Drawing.Point(714, 181);
            this.TxtSupIdToSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSupIdToSearch.Multiline = true;
            this.TxtSupIdToSearch.Name = "TxtSupIdToSearch";
            this.TxtSupIdToSearch.Size = new System.Drawing.Size(349, 42);
            this.TxtSupIdToSearch.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(371, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 45);
            this.label1.TabIndex = 160;
            this.label1.Text = "Supplier Details";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(177, 181);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(120, 42);
            this.guna2Button3.TabIndex = 159;
            this.guna2Button3.Text = "Update";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(45, 181);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(123, 42);
            this.guna2Button2.TabIndex = 158;
            this.guna2Button2.Text = "Add";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // CmbCategoery
            // 
            this.CmbCategoery.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CmbCategoery.FormattingEnabled = true;
            this.CmbCategoery.Items.AddRange(new object[] {
            "Food",
            "Accessories",
            "Medicine",
            "Hospital essentials"});
            this.CmbCategoery.Location = new System.Drawing.Point(670, 37);
            this.CmbCategoery.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCategoery.Name = "CmbCategoery";
            this.CmbCategoery.Size = new System.Drawing.Size(370, 29);
            this.CmbCategoery.TabIndex = 156;
            // 
            // LblCategoery
            // 
            this.LblCategoery.AutoSize = true;
            this.LblCategoery.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblCategoery.Location = new System.Drawing.Point(538, 40);
            this.LblCategoery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoery.Name = "LblCategoery";
            this.LblCategoery.Size = new System.Drawing.Size(128, 23);
            this.LblCategoery.TabIndex = 157;
            this.LblCategoery.Text = "Category         :";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtAddress.Location = new System.Drawing.Point(175, 127);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(312, 29);
            this.TxtAddress.TabIndex = 149;
            // 
            // MangAddr
            // 
            this.MangAddr.AutoSize = true;
            this.MangAddr.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MangAddr.Location = new System.Drawing.Point(39, 130);
            this.MangAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MangAddr.Name = "MangAddr";
            this.MangAddr.Size = new System.Drawing.Size(134, 23);
            this.MangAddr.TabIndex = 150;
            this.MangAddr.Text = "Address            :";
            // 
            // TxtContactNo
            // 
            this.TxtContactNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtContactNo.Location = new System.Drawing.Point(670, 82);
            this.TxtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContactNo.Name = "TxtContactNo";
            this.TxtContactNo.Size = new System.Drawing.Size(370, 29);
            this.TxtContactNo.TabIndex = 147;
            // 
            // LblContNo
            // 
            this.LblContNo.AutoSize = true;
            this.LblContNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblContNo.Location = new System.Drawing.Point(534, 85);
            this.LblContNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContNo.Name = "LblContNo";
            this.LblContNo.Size = new System.Drawing.Size(136, 23);
            this.LblContNo.TabIndex = 148;
            this.LblContNo.Text = "Contact No.      :";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.Location = new System.Drawing.Point(40, 40);
            this.LblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(133, 23);
            this.LblSupplier.TabIndex = 135;
            this.LblSupplier.Text = "Supplier ID       :";
            // 
            // lblId
            // 
            this.lblId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblId.Location = new System.Drawing.Point(175, 37);
            this.lblId.Margin = new System.Windows.Forms.Padding(4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(312, 29);
            this.lblId.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 139;
            this.label2.Text = "Supplier Name :";
            // 
            // TxtSupName
            // 
            this.TxtSupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSupName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtSupName.Location = new System.Drawing.Point(175, 82);
            this.TxtSupName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSupName.Name = "TxtSupName";
            this.TxtSupName.Size = new System.Drawing.Size(312, 29);
            this.TxtSupName.TabIndex = 136;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SupplierID,
            this.SupplierName,
            this.ContNo,
            this.Address});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 287);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1079, 410);
            this.listView1.TabIndex = 186;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SupplierID
            // 
            this.SupplierID.Text = "Supplier ID";
            this.SupplierID.Width = 154;
            // 
            // SupplierName
            // 
            this.SupplierName.Text = "Supplier Name";
            this.SupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SupplierName.Width = 406;
            // 
            // ContNo
            // 
            this.ContNo.Text = "Contact No.";
            this.ContNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContNo.Width = 215;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 183;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1079, 709);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDetails;
        internal System.Windows.Forms.ComboBox CmbCategoery;
        internal System.Windows.Forms.Label LblCategoery;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label MangAddr;
        private System.Windows.Forms.TextBox TxtContactNo;
        private System.Windows.Forms.Label LblContNo;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.TextBox lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSupName;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSupIdToSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SupplierID;
        private System.Windows.Forms.ColumnHeader SupplierName;
        private System.Windows.Forms.ColumnHeader ContNo;
        private System.Windows.Forms.ColumnHeader Address;
    }
}