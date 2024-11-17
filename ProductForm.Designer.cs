
namespace PetShopAndVeterinaryManagementSystem
{
    partial class ProductForm
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
            this.PanelProdDetails = new System.Windows.Forms.Panel();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.LblProdDetails = new System.Windows.Forms.Label();
            this.Btntosearch = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSupIdToSearch = new System.Windows.Forms.TextBox();
            this.CmbQty = new System.Windows.Forms.ComboBox();
            this.Qty = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.LblProductID = new System.Windows.Forms.Label();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblId = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LblCategoery = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelProdDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelProdDetails
            // 
            this.PanelProdDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.PanelProdDetails.Controls.Add(this.BtnDelete);
            this.PanelProdDetails.Controls.Add(this.Btntosearch);
            this.PanelProdDetails.Controls.Add(this.TxtSupIdToSearch);
            this.PanelProdDetails.Controls.Add(this.CmbQty);
            this.PanelProdDetails.Controls.Add(this.Qty);
            this.PanelProdDetails.Controls.Add(this.CmbCategory);
            this.PanelProdDetails.Controls.Add(this.BtnSearch);
            this.PanelProdDetails.Controls.Add(this.BtnAdd);
            this.PanelProdDetails.Controls.Add(this.LblProductID);
            this.PanelProdDetails.Controls.Add(this.BtnUpdate);
            this.PanelProdDetails.Controls.Add(this.lblId);
            this.PanelProdDetails.Controls.Add(this.LblProductName);
            this.PanelProdDetails.Controls.Add(this.TxtProductName);
            this.PanelProdDetails.Controls.Add(this.LblCategoery);
            this.PanelProdDetails.Controls.Add(this.TxtPrice);
            this.PanelProdDetails.Controls.Add(this.LblPrice);
            this.PanelProdDetails.Location = new System.Drawing.Point(0, 47);
            this.PanelProdDetails.Margin = new System.Windows.Forms.Padding(4);
            this.PanelProdDetails.Name = "PanelProdDetails";
            this.PanelProdDetails.Size = new System.Drawing.Size(1097, 244);
            this.PanelProdDetails.TabIndex = 133;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Animated = true;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Gray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(408, 192);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 42);
            this.BtnDelete.TabIndex = 162;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblProdDetails
            // 
            this.LblProdDetails.AutoSize = true;
            this.LblProdDetails.BackColor = System.Drawing.Color.Transparent;
            this.LblProdDetails.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblProdDetails.Location = new System.Drawing.Point(358, -2);
            this.LblProdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProdDetails.Name = "LblProdDetails";
            this.LblProdDetails.Size = new System.Drawing.Size(383, 45);
            this.LblProdDetails.TabIndex = 161;
            this.LblProdDetails.Text = "Product Details";
            // 
            // Btntosearch
            // 
            this.Btntosearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.Btntosearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btntosearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btntosearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btntosearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btntosearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btntosearch.FillColor = System.Drawing.Color.SlateGray;
            this.Btntosearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btntosearch.ForeColor = System.Drawing.Color.White;
            this.Btntosearch.Location = new System.Drawing.Point(554, 192);
            this.Btntosearch.Name = "Btntosearch";
            this.Btntosearch.Size = new System.Drawing.Size(146, 42);
            this.Btntosearch.TabIndex = 160;
            this.Btntosearch.Text = "Search";
            this.Btntosearch.Click += new System.EventHandler(this.Btntosearch_Click);
            // 
            // TxtSupIdToSearch
            // 
            this.TxtSupIdToSearch.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TxtSupIdToSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtSupIdToSearch.Location = new System.Drawing.Point(707, 192);
            this.TxtSupIdToSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSupIdToSearch.Multiline = true;
            this.TxtSupIdToSearch.Name = "TxtSupIdToSearch";
            this.TxtSupIdToSearch.Size = new System.Drawing.Size(357, 42);
            this.TxtSupIdToSearch.TabIndex = 159;
            // 
            // CmbQty
            // 
            this.CmbQty.FormattingEnabled = true;
            this.CmbQty.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.CmbQty.Location = new System.Drawing.Point(143, 117);
            this.CmbQty.Name = "CmbQty";
            this.CmbQty.Size = new System.Drawing.Size(178, 24);
            this.CmbQty.TabIndex = 138;
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Qty.Location = new System.Drawing.Point(12, 118);
            this.Qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(125, 23);
            this.Qty.TabIndex = 137;
            this.Qty.Text = "Quantity         :";
            // 
            // CmbCategory
            // 
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "Food",
            "Accessories",
            "Clothes",
            "Vaccines"});
            this.CmbCategory.Location = new System.Drawing.Point(941, 64);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(124, 24);
            this.CmbCategory.TabIndex = 136;
            // 
            // BtnSearch
            // 
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.Color.Gray;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(30, 192);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(117, 42);
            this.BtnSearch.TabIndex = 132;
            this.BtnSearch.Text = "Search";
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.FillColor = System.Drawing.Color.Gray;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(153, 192);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(123, 42);
            this.BtnAdd.TabIndex = 133;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductID.Location = new System.Drawing.Point(11, 65);
            this.LblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(126, 23);
            this.LblProductID.TabIndex = 0;
            this.LblProductID.Text = "Product ID      :";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Animated = true;
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.FillColor = System.Drawing.Color.Gray;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(282, 192);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 42);
            this.BtnUpdate.TabIndex = 134;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblId
            // 
            this.lblId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblId.Location = new System.Drawing.Point(143, 62);
            this.lblId.Margin = new System.Windows.Forms.Padding(4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(178, 29);
            this.lblId.TabIndex = 68;
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(345, 65);
            this.LblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(127, 23);
            this.LblProductName.TabIndex = 15;
            this.LblProductName.Text = "Product name :";
            // 
            // TxtProductName
            // 
            this.TxtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtProductName.Location = new System.Drawing.Point(477, 62);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(308, 29);
            this.TxtProductName.TabIndex = 1;
            // 
            // LblCategoery
            // 
            this.LblCategoery.AutoSize = true;
            this.LblCategoery.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblCategoery.Location = new System.Drawing.Point(809, 65);
            this.LblCategoery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoery.Name = "LblCategoery";
            this.LblCategoery.Size = new System.Drawing.Size(128, 23);
            this.LblCategoery.TabIndex = 67;
            this.LblCategoery.Text = "Category         :";
            // 
            // TxtPrice
            // 
            this.TxtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtPrice.Location = new System.Drawing.Point(474, 115);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(315, 29);
            this.TxtPrice.TabIndex = 3;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblPrice.Location = new System.Drawing.Point(345, 118);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(126, 23);
            this.LblPrice.TabIndex = 63;
            this.LblPrice.Text = "Price               :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 437);
            this.dataGridView1.TabIndex = 134;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ProductFomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1097, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblProdDetails);
            this.Controls.Add(this.PanelProdDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductFomr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductFomr";
            this.Load += new System.EventHandler(this.ProductFomr_Load);
            this.PanelProdDetails.ResumeLayout(false);
            this.PanelProdDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelProdDetails;
        private System.Windows.Forms.ComboBox CmbQty;
        internal System.Windows.Forms.Label Qty;
        private System.Windows.Forms.ComboBox CmbCategory;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private System.Windows.Forms.Label LblProductID;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private System.Windows.Forms.TextBox lblId;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.TextBox TxtProductName;
        internal System.Windows.Forms.Label LblCategoery;
        internal System.Windows.Forms.TextBox TxtPrice;
        internal System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblProdDetails;
        private Guna.UI2.WinForms.Guna2Button Btntosearch;
        private System.Windows.Forms.TextBox TxtSupIdToSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
    }
}